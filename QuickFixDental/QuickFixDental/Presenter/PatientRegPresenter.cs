﻿using QuickFixDental.BusinessLogic;
using QuickFixDental.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickFixDental.Presenter
{
    public class PatientRegPresenter
    {
        private readonly IPatientRegView _patientView;
        private readonly IPatientBL _patientBL;
        public PatientRegPresenter(IPatientBL patientBL, IPatientRegView patientView,Int16 PatientId)
        {
            _patientView = patientView;
            _patientBL = patientBL;
            _patientView.Submit += _patientView_Submit;
            if(PatientId>0)
            FillPatientDetails(PatientId);
        }

        private void FillPatientDetails(Int16 id)
        {
            var patient=_patientBL.GetPatient(id);
            _patientView.Patient_ID = id;
            _patientView.PatientName = patient.Name;
            _patientView.Address = patient.Address;
            _patientView.DOB = patient.DOB;
            _patientView.GPName = patient.GPName;
            _patientView.GPAddress = patient.GPAddress;
            _patientView.Email = patient.Email;
            _patientView.PhoneNo = patient.PhoneNo;

        }
        private void _patientView_Submit(object sender, EventArgs e)
        {
            if (_patientView.Patient_ID > 0)
            {
                var patient = _patientBL.GetPatient(_patientView.Patient_ID);
                patient.Name = _patientView.PatientName;
                patient.Address = _patientView.Address;
                _patientBL.UpdatePatient(patient);
            }
            else
            {
                Model.Patient patient = new Model.Patient();
                patient.Name=_patientView.PatientName;
                patient.Address=_patientView.Address;
                patient.DOB=_patientView.DOB;
                patient.GPName=_patientView.GPName;
                patient.GPAddress=_patientView.GPAddress;
                patient.Email=_patientView.Email;
                patient.PhoneNo=_patientView.PhoneNo;
                patient.MedicalHistory = new Model.MedicalHistory();
                patient.MedicalHistory.AllergicTo = "Nil";
                patient.MedicalHistory.LastUpdateBy = patient.Name;
                patient.MedicalHistory.LastUpdateDate = DateTime.Now;
                _patientBL.AddPatient(patient);
            }
        }

        public void ShowScreen()
        {
            _patientView.ShowScreen();
        }

    }
}