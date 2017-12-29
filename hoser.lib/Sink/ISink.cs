using System;
using System.Collections.Generic;
using System.Text;

namespace hoser.lib
{
   public interface ISink
	{
		IEnumerable<IField> Fields { get; }

		void Write(dynamic record);
	}
}
