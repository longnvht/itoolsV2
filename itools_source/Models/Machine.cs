using System;

namespace itools_source.Models
{
	public class Machine
	{
		private int _iMachineId;

		public int iMachineId
		{
			get { return _iMachineId; }
			set { _iMachineId = value; }
		}

		private string _strMachineName;

		public string strMachineName
		{
			get { return _strMachineName; }
			set { _strMachineName = value; }
		}

		private string _strMachineCode;

		public string strMachineCode
		{
			get { return _strMachineCode; }
			set { _strMachineCode = value; }
		}

		private string _strModel;

		public string strModel
		{
			get { return _strModel; }
			set { _strModel = value; }
		}

		private string _strLocation;

		public string strLocation
		{
			get { return _strLocation; }
			set { _strLocation = value; }
		}

		private string _strDescription;

		public string strDescription
		{
			get { return _strDescription; }
			set { _strDescription = value; }
		}

		private DateTime _dtCreateDate;

		public DateTime dtCreateDate
		{
			get { return _dtCreateDate; }
			set { _dtCreateDate = value; }
		}

		private DateTime _dtUpdateDate;

		public DateTime dtUpdateDate
		{
			get { return _dtUpdateDate; }
			set { _dtUpdateDate = value; }
		}

		private byte _isActive;

		public byte isActive
		{
			get { return _isActive; }
			set { _isActive = value; }
		}

		private int _iCompanyId;

		public int iCompanyId
		{
			get { return _iCompanyId; }
			set { _iCompanyId = value; }
		}
	}
}
