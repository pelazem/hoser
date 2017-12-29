using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Text;

namespace hoser.lib
{
	public class FileSink : ISink
	{
		#region Variables

		private IEnumerable<IField> _fields = null;

		#endregion

		#region Properties

		public IEnumerable<IField> Fields
		{
			get
			{
				if (_fields == null)
					_fields = new List<IField>();

				return _fields;
			}
			private set
			{
				_fields = value;
			}
		}

		#endregion

		public void Write(dynamic record)
		{

		}


	}
}
