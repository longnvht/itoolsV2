using System;

namespace itools_source.Models
{
    public class CompanyModel
    {
        private int companyID;
        private string companyCode;
        private string companyName;
        private string companyAddress;
        private string companyLocation;

        public int CompanyID { get => companyID; set => companyID = value; }
        public string CompanyCode { get => companyCode; set => companyCode = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
        public string CompanyAddress { get => companyAddress; set => companyAddress = value; }
        public string CompanyLocation { get => companyLocation; set => companyLocation = value; }
    }
}
