using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickFixDental.BusinessLogic;
using QuickFixDental.Model;
using QuickFixDental;
using System;
using Moq;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject
{
    /// <summary>
    ///Reference: https://docs.microsoft.com/en-us/ef/ef6/fundamentals/testing/mocking
    /// </summary>

    [TestClass]
    public class UnitTest1
    {
        PatientBL patientBL;

        [TestMethod]
        public void AddPatientTest()
        {
            var mockSet = new Mock<DbSet<Patient>>();
            var mockContext = new Mock<MyDBEntities>();
            mockContext.Setup(m => m.Patients).Returns(mockSet.Object);
            patientBL = new PatientBL(mockContext.Object);
            var Patient = new Patient();
            Patient.Name = "Test Patient";
            Patient.Address = "Test Address";
            Patient.DOB = DateTime.Now;
            Patient.Email = "asaasf.sds.com";
            Patient.GPName = "xyx";
            Patient.GPAddress = "dsfdsf";
            var ret = patientBL.AddPatient(Patient);
            mockSet.Verify(m => m.Add(It.IsAny<Patient>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
        }

        [TestMethod]
        public void GetPatientsTest()
        {
            var data = new List<Patient>
            {
                new Patient { Name = "AAA" },
                new Patient { Name = "BBB" },
                new Patient { Name = "ZZZ" },
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Patient>>();
            mockSet.As<IQueryable<Patient>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Patient>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Patient>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Patient>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<MyDBEntities>();
            mockContext.Setup(c => c.Patients).Returns(mockSet.Object);

            var service = new PatientBL(mockContext.Object);
            var patients = service.GetPatients();

            Assert.AreEqual(3, patients.Count);
            Assert.AreEqual("AAA", patients[0].Name);
            Assert.AreEqual("BBB", patients[1].Name);
            Assert.AreEqual("ZZZ", patients[2].Name);
        }


        [TestMethod]
        public void GetMedicalHistory()
        {
            var data = new List<Patient>
            {
                new Patient { Name = "AAA",Patient_ID=1 },
                new Patient { Name = "BBB",Patient_ID=2 },
                new Patient { Name = "ZZZ" ,Patient_ID=3},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Patient>>();
            mockSet.As<IQueryable<Patient>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Patient>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Patient>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Patient>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());
            data.ToList().ForEach(l =>
            {
                l.MedicalHistory = new MedicalHistory
                {
                    AllergicTo = "gel",
                    Patient_ID = l.Patient_ID,
                    MedHistory_ID = l.Patient_ID,
                    LastUpdateBy = "Staff1",
                    LastUpdateDate = DateTime.Now.Date
                };
            });
            var mockContext = new Mock<MyDBEntities>();
            mockContext.Setup(c => c.Patients).Returns(mockSet.Object);

            var service = new PatientBL(mockContext.Object);
            var medicalHistory = service.GetPatients().Where(m=>m.MedicalHistory.Patient_ID==1).FirstOrDefault();          
            Assert.AreEqual(1, medicalHistory.Patient_ID);
        }

    }
}
