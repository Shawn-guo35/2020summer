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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public 
	partial class 添加场地信息 : System.Windows.Forms.Form
	{
		
		//Form 重写 Dispose，以清理组件列表。
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
		
		//Windows 窗体设计器所必需的
		private System.ComponentModel.Container components = null;
		
		//注意: 以下过程是 Windows 窗体设计器所必需的
		//可以使用 Windows 窗体设计器修改它。
		//不要使用代码编辑器修改它。
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			this.lblResults1 = new System.Windows.Forms.Label();
			base.Load += new System.EventHandler(添加场地信息_Load);
			this.lblResults2 = new System.Windows.Forms.Label();
			this.txtGymName = new System.Windows.Forms.TextBox();
			this.txtGymNum = new System.Windows.Forms.TextBox();
			this.btnReturn = new System.Windows.Forms.Button();
			this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			this.btnInsertVtype = new System.Windows.Forms.Button();
			this.btnInsertVtype.Click += new System.EventHandler(this.btnInsertVtype_Click);
			this.SqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
			this.SqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.SqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.SqlInsertCommand = new System.Data.SqlClient.SqlCommand();
			this.SqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.SqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.ChangguanDataSet1 = new WindowsApp1.changguanDataSet();
			((System.ComponentModel.ISupportInitialize) this.ChangguanDataSet1).BeginInit();
			this.SuspendLayout();
			//
			//lblResults1
			//
			this.lblResults1.AutoSize = true;
			this.lblResults1.Font = new System.Drawing.Font("宋体", (float) (10.8F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.lblResults1.Location = new System.Drawing.Point(106, 64);
			this.lblResults1.Name = "lblResults1";
			this.lblResults1.Size = new System.Drawing.Size(104, 19);
			this.lblResults1.TabIndex = 0;
			this.lblResults1.Text = "场地名称：";
			//
			//lblResults2
			//
			this.lblResults2.AutoSize = true;
			this.lblResults2.Font = new System.Drawing.Font("宋体", (float) (10.8F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.lblResults2.Location = new System.Drawing.Point(106, 164);
			this.lblResults2.Name = "lblResults2";
			this.lblResults2.Size = new System.Drawing.Size(104, 19);
			this.lblResults2.TabIndex = 1;
			this.lblResults2.Text = "场地编号：";
			//
			//txtGymName
			//
			this.txtGymName.Location = new System.Drawing.Point(264, 61);
			this.txtGymName.Name = "txtGymName";
			this.txtGymName.Size = new System.Drawing.Size(100, 25);
			this.txtGymName.TabIndex = 2;
			//
			//txtGymNum
			//
			this.txtGymNum.Location = new System.Drawing.Point(264, 161);
			this.txtGymNum.Name = "txtGymNum";
			this.txtGymNum.Size = new System.Drawing.Size(100, 25);
			this.txtGymNum.TabIndex = 3;
			//
			//btnReturn
			//
			this.btnReturn.Location = new System.Drawing.Point(322, 278);
			this.btnReturn.Name = "btnReturn";
			this.btnReturn.Size = new System.Drawing.Size(96, 51);
			this.btnReturn.TabIndex = 21;
			this.btnReturn.Text = "退出";
			//
			//btnCancel
			//
			this.btnCancel.Location = new System.Drawing.Point(181, 278);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(96, 51);
			this.btnCancel.TabIndex = 20;
			this.btnCancel.Text = "取消添加";
			//
			//btnInsertVtype
			//
			this.btnInsertVtype.Location = new System.Drawing.Point(33, 278);
			this.btnInsertVtype.Name = "btnInsertVtype";
			this.btnInsertVtype.Size = new System.Drawing.Size(96, 51);
			this.btnInsertVtype.TabIndex = 19;
			this.btnInsertVtype.Text = "确认添加";
			//
			//SqlDataAdapter1
			//
			this.SqlDataAdapter1.DeleteCommand = this.SqlDeleteCommand1;
			this.SqlDataAdapter1.InsertCommand = this.SqlInsertCommand;
			this.SqlDataAdapter1.SelectCommand = this.SqlSelectCommand1;
			this.SqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {new System.Data.Common.DataTableMapping("Table", "Venue", new System.Data.Common.DataColumnMapping[] {new System.Data.Common.DataColumnMapping("Vname", "Vname"), new System.Data.Common.DataColumnMapping("Vno", "Vno")})});
			this.SqlDataAdapter1.UpdateCommand = this.SqlUpdateCommand1;
			//
			//SqlDeleteCommand1
			//
			this.SqlDeleteCommand1.CommandText = "DELETE FROM [Venue] WHERE (([Vname] = @Original_Vname) AND ([Vno] = @Original_Vno" +
				"))";
			this.SqlDeleteCommand1.Connection = this.SqlConnection1;
			this.SqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {new System.Data.SqlClient.SqlParameter("@Original_Vname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, System.Convert.ToByte(0), System.Convert.ToByte(0), "Vname", System.Data.DataRowVersion.Original, null), new System.Data.SqlClient.SqlParameter("@Original_Vno", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, System.Convert.ToByte(0), System.Convert.ToByte(0), "Vno", System.Data.DataRowVersion.Original, null)});
			//
			//SqlConnection1
			//
			this.SqlConnection1.ConnectionString = "Data Source=DESKTOP-DSP6URK\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=c" +
				"hangguan;";
			this.SqlConnection1.FireInfoMessageEventOnUserErrors = false;
			//
			//SqlInsertCommand
			//
			this.SqlInsertCommand.CommandText = "INSERT INTO [Venue] ([Vname], [Vno]) VALUES (@Vname, @Vno);" + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(13)) + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(10)) + "SELECT Vname, Vno FR" +
				"OM Venue WHERE (Vname = @Vname) AND (Vno = @Vno)";
			this.SqlInsertCommand.Connection = this.SqlConnection1;
			this.SqlInsertCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {new System.Data.SqlClient.SqlParameter("@Vname", System.Data.SqlDbType.VarChar, 0, "Vname"), new System.Data.SqlClient.SqlParameter("@Vno", System.Data.SqlDbType.VarChar, 0, "Vno")});
			//
			//SqlSelectCommand1
			//
			this.SqlSelectCommand1.CommandText = "SELECT    Vname, Vno  FROM  Venue";
			this.SqlSelectCommand1.Connection = this.SqlConnection1;
			//
			//SqlUpdateCommand1
			//
			this.SqlUpdateCommand1.CommandText = "UPDATE [Venue] SET [Vname] = @Vname, [Vno] = @Vno WHERE (([Vname] = @Original_Vna" +
				"me) AND ([Vno] = @Original_Vno));" + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(13)) + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(10)) + "SELECT Vname, Vno FROM Venue WHERE (Vname = @" +
"Vname) AND (Vno = @Vno)";
			this.SqlUpdateCommand1.Connection = this.SqlConnection1;
			this.SqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {new System.Data.SqlClient.SqlParameter("@Vname", System.Data.SqlDbType.VarChar, 0, "Vname"), new System.Data.SqlClient.SqlParameter("@Vno", System.Data.SqlDbType.VarChar, 0, "Vno"), new System.Data.SqlClient.SqlParameter("@Original_Vname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, System.Convert.ToByte(0), System.Convert.ToByte(0), "Vname", System.Data.DataRowVersion.Original, null), new System.Data.SqlClient.SqlParameter("@Original_Vno", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, System.Convert.ToByte(0), System.Convert.ToByte(0), "Vno", System.Data.DataRowVersion.Original, null)});
			//
			//ChangguanDataSet1
			//
			this.ChangguanDataSet1.DataSetName = "changguanDataSet";
			this.ChangguanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//添加场地信息
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (8.0F), (float) (15.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(469, 362);
			this.Controls.Add(this.btnReturn);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnInsertVtype);
			this.Controls.Add(this.txtGymNum);
			this.Controls.Add(this.txtGymName);
			this.Controls.Add(this.lblResults2);
			this.Controls.Add(this.lblResults1);
			this.Name = "添加场地信息";
			this.Text = "添加场地信息";
			((System.ComponentModel.ISupportInitialize) this.ChangguanDataSet1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		
		internal Label lblResults1;
		internal Label lblResults2;
		internal TextBox txtGymName;
		internal TextBox txtGymNum;
		internal Button btnReturn;
		internal Button btnCancel;
		internal Button btnInsertVtype;
		internal System.Data.SqlClient.SqlDataAdapter SqlDataAdapter1;
		internal System.Data.SqlClient.SqlCommand SqlDeleteCommand1;
		internal System.Data.SqlClient.SqlCommand SqlInsertCommand;
		internal System.Data.SqlClient.SqlCommand SqlSelectCommand1;
		internal System.Data.SqlClient.SqlCommand SqlUpdateCommand1;
		internal System.Data.SqlClient.SqlConnection SqlConnection1;
		internal changguanDataSet ChangguanDataSet1;
	}
	
}
