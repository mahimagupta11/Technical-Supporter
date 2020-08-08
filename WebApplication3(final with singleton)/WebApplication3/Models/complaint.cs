using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class complaint
    {
        int _complaintId;
        public int ComplaintId
        {
            get
            { return _complaintId;}
            set
            { _complaintId = value;}
        }

        string _complaintBody;
        public string Complaint_body
        {
            get
            { return _complaintBody; }
            set
            { _complaintBody = value; }
        }

        DateTime _dos;
        public DateTime Date_of_submission
        {
            get
            {return _dos;}
            set
            {_dos = value;}
        }

        DateTime _dor;
        public DateTime Date_of_resolution
        {
            get
            { return _dor; }
            set
            { _dor = value; }
        }

        employee _submitted_by;
        public employee Submitted_By
       {
           get
           { return _submitted_by; }
           set
           { _submitted_by = value; }
       }

        employee _assigned_to;
        public employee Assigned_To
        {
            get
            { return _assigned_to; }
            set
            { _assigned_to = value; }
        }

        string _sol_sug;
        public string Sol_sugg
        {
            get
            { return _sol_sug; }
            set
            { _sol_sug = value;}
        }

        string status;
        public string Status
        {
            get
            { return status; }
            set
            { status = value; }
        }

        string type;
        public string Type
        {
            get
            { return type; }
            set
            {type = value; }
        }

    }

}