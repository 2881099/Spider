using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace System.Windows.Forms {
	public class MyListView : ListView {
		public MyListView()
			: base() {
			base.SetStyle(ControlStyles.DoubleBuffer |
				ControlStyles.OptimizedDoubleBuffer |
				ControlStyles.AllPaintingInWmPaint, true);
			base.UpdateStyles();
		}
	}
}
