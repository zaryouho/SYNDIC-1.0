using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;



namespace SYNDIC_1._0
{
	public static class DBHelper
	{
		public static SqlConnection connection = new SqlConnection();
		public static SqlDataAdapter dataAdapter;
		public static SqlCommandBuilder commandBuilder;
		public static DataSet dataSet = new DataSet();


		static public void ouvrirConnection(string name)
		{
			if (string.IsNullOrEmpty(name))
			{
				throw new ArgumentException("message", nameof(name));
			}

			if (connection.State != ConnectionState.Open)
			{
				try
				{
					connection.ConnectionString = ConfigurationManager.ConnectionStrings[name].ToString();
					connection.Open();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				
			}
		}

		static public void fermerConnection()
		{
				if (connection.State == ConnectionState.Open)
				{
					connection.Close();
					connection = null;
				}
			

			
		}

		static public void creerRelation(string tpk, string tfk, string pk, string fk)
		{
			if (string.IsNullOrEmpty(tpk))
			{
				throw new ArgumentException("message", nameof(tpk));
			}

			if (string.IsNullOrEmpty(tfk))
			{
				throw new ArgumentException("message", nameof(tfk));
			}

			if (string.IsNullOrEmpty(pk))
			{
				throw new ArgumentException("message", nameof(pk));
			}

			if (string.IsNullOrEmpty(fk))
			{
				throw new ArgumentException("message", nameof(fk));
			}

			string nomRelation = "rel_" + tpk + "_" + tfk;
			DataColumn column1 = dataSet.Tables[tpk].Columns[pk];
			DataColumn column2 = dataSet.Tables[tfk].Columns[fk];

			DataRelation relation = new DataRelation(nomRelation, column1, column2);

			if (!dataSet.Relations.Contains(nomRelation))
				dataSet.Relations.Add(relation);

		}

		static public void remplir_dataset(string sql, string table)
		{
			if (string.IsNullOrEmpty(sql))
			{
				throw new ArgumentException("message", nameof(sql));
			}

			if (string.IsNullOrEmpty(table))
			{
				throw new ArgumentException("message", nameof(table));
			}


			try
			{
				SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
				if (!dataSet.Tables.Contains(table))
					dataAdapter.Fill(dataSet, table);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		

		}

		static public BindingSource remplir_bindingsource(string table)
		{
			if (string.IsNullOrEmpty(table))
			{
				throw new ArgumentException("message", nameof(table));
			}

			BindingSource bindingSource = new BindingSource();

			bindingSource.DataSource = dataSet;
			bindingSource.DataMember = table;

			return bindingSource;

		}
		
		static public BindingSource remplir_bindingsource(string tpk, string pk, string tfk, string fk, BindingSource bsPk)
		{
			if (tfk is null)
			{
				throw new ArgumentNullException(nameof(tfk));
			}

			if (string.IsNullOrEmpty(tpk))
			{
				throw new ArgumentException("message", nameof(tpk));
			}

			if (string.IsNullOrEmpty(pk))
			{
				throw new ArgumentException("message", nameof(pk));
			}

			if (string.IsNullOrEmpty(fk))
			{
				throw new ArgumentException("message", nameof(fk));
			}

			if (bsPk is null)
			{
				throw new ArgumentNullException(nameof(bsPk));
			}

			BindingSource bindingSource = new BindingSource();

			creerRelation(tpk, tfk, pk, fk);

			bindingSource.DataSource = bsPk;
			bindingSource.DataMember = "rel_" + tpk + "_" + tfk;

			return bindingSource;

		}

		static public void remplir_ListControl(ListControl listControl, BindingSource bindingSource, string displaymember, string valuemember)
		{

			if (bindingSource is null)
			{
				throw new ArgumentNullException(nameof(bindingSource));
			}

			if (string.IsNullOrEmpty(displaymember))
			{
				throw new ArgumentException("message", nameof(displaymember));
			}

			if (string.IsNullOrEmpty(valuemember))
			{
				throw new ArgumentException("message", nameof(valuemember));
			}

			listControl.DataSource = bindingSource;
			listControl.DisplayMember = displaymember;
			listControl.ValueMember = valuemember;

		}

		static public void remplir_Grille(DataGridView dataGridView, BindingSource bindingSource)
		{
			if (bindingSource is null)
			{
				throw new ArgumentNullException(nameof(bindingSource));
			}

			dataGridView.DataSource = bindingSource;
		}

		static public void syncroniser(string table)
		{
			if (string.IsNullOrEmpty(table))
			{
				throw new ArgumentException("message", nameof(table));
			}

			try
			{
				dataAdapter = new SqlDataAdapter("select * from " + table, connection);
				commandBuilder = new SqlCommandBuilder(dataAdapter);
				dataAdapter.Update(dataSet.Tables[table]);
			}
			catch (Exception ex )
			{
				MessageBox.Show(ex.Message);
			}


		}

	}

}

