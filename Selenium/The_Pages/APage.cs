using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages.The_Pages
{
	public abstract class APage<T>
	{
		protected Pages page;
		protected T selectors;
		public T Selectors
		{
			get { return selectors; }
		}

		protected APage(Pages p, T t)
		{
			page = p;
			selectors = t;
		}
	}
}
