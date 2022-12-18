using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArquitecture.Presenters
{
	/// <summary>
	/// Interface Generica
	/// Define la plantilla de los presentadores: formatear los datos para que sean presentados
	/// </summary>
	/// <typeparam name="TFormatDataType"></typeparam>
	public interface IPresenter<TFormatDataType>
	{
		public TFormatDataType Content { get; }
	}
}
