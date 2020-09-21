using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Common {

	public interface IEntity {
		int Id { get; }
		string DataDescription();
	}

	public interface IFoxEntity : IEntity {
		int? FoxId { get; set; }
		bool FromFox { get; set; }
	}

	public interface ITable : IFoxEntity {
		int SqlId { get; set; }
		string QueOp { get; set; }
	}

	public interface ILookup : IEntity {
		string Code { get; set; }
		string Name { get; set; }
		string CodeAndName { get; }
		StatusType Status { get; set; }
	}

	public interface IVerify : IEntity {
		bool Verify { get; set; }
		string VerifyDescription { get; }
	}

	public interface IHewEntity : INotifyPropertyChanged {
	}

}
