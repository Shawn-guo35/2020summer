// VBConversions Note: VB project level imports
using System.Collections.Generic;
using System;
using System.Linq;
using System.Drawing;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Data;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using System.Collections;
using System.Windows.Forms;
// End of VB project level imports

using WindowsApp1;

namespace WindowsApp1
{
	public partial class Yuyue
	{
		public Yuyue()
		{
			InitializeComponent();
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static Yuyue defaultInstance;
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static Yuyue Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new Yuyue();
					defaultInstance.FormClosed += new System.Windows.Forms.FormClosedEventHandler(defaultInstance_FormClosed);
				}
				
				return defaultInstance;
			}
			set
			{
				defaultInstance = value;
			}
		}
		
		static void defaultInstance_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
		{
			defaultInstance = null;
		}
		
#endregion
		public void btnTennis_Click(object sender, EventArgs e)
		{
			MessageBox.Show("敬请期待！");
		}
		
		public void btnBasketball_Click(object sender, EventArgs e)
		{
            //Me.Hide()

            //用户界面 form0 = new 用户界面();
            Form form = new 器材预约();
            //form0.showChildForm(form);
            
            form.FormBorderStyle = FormBorderStyle.None;
            form.ControlBox = false;
            form.Size = new Size(this.Size.Width - 15, this.Size.Height - 25);
            form.Location = new Point(SystemInformation.WorkingArea.Width - form.Width, SystemInformation.WorkingArea.Height - form.Height);
            form.Show();
            //orderBasketball.Default.Show();           
        }
		
		public void btnSoccer_Click(object sender, EventArgs e)
		{
			MessageBox.Show("敬请期待！");
		}
		
		public void btnBasketball1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("敬请期待！");
		}
		
		public void btnBadminton_Click(object sender, EventArgs e)
		{
			MessageBox.Show("敬请期待！");
		}
		
		public void btnPingpang_Click(object sender, EventArgs e)
		{
			MessageBox.Show("敬请期待！");
		}
		
		public void Yuyue_Load(object sender, EventArgs e)
		{
			
		}
    }
}
