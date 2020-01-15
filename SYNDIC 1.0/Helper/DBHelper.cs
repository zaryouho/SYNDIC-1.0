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
        static SqlConnection cn = new SqlConnection();
        static DataSet ds = new DataSet();


        static public void ouvrirConnection(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("message", nameof(name));
            }

            if (cn.State != ConnectionState.Open)
            {
                cn.ConnectionString = ConfigurationManager.ConnectionStrings[name].ToString();
                cn.Open();
            }
        }


        static public void fermerConnection()
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
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

            string nomRel = "rel_" + tpk + "_" + tfk;
            DataColumn c1 = ds.Tables[tpk].Columns[pk];
            DataColumn c2 = ds.Tables[tfk].Columns[fk];

            DataRelation r = new DataRelation(nomRel, c1, c2);

            if (!ds.Relations.Contains(nomRel))
                ds.Relations.Add(r);

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


            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            if (!ds.Tables.Contains(table))
                da.Fill(ds, table);
            da = null;

        }

        static public BindingSource remplir_bindingsource(string table)
        {
            if (string.IsNullOrEmpty(table))
            {
                throw new ArgumentException("message", nameof(table));
            }

            BindingSource bs = new BindingSource();



            bs.DataSource = ds;
            bs.DataMember = table;

            return bs;

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

            BindingSource bs = new BindingSource();



            creerRelation(tpk, tfk, pk, fk);

            bs.DataSource = bsPk;
            bs.DataMember = "rel_" + tpk + "_" + tfk;

            return bs;

        }

        static public void remplir_ListControl(ListControl l, BindingSource bs, string displaymember, string valuemember)
        {


            if (bs is null)
            {
                throw new ArgumentNullException(nameof(bs));
            }

            if (string.IsNullOrEmpty(displaymember))
            {
                throw new ArgumentException("message", nameof(displaymember));
            }

            if (string.IsNullOrEmpty(valuemember))
            {
                throw new ArgumentException("message", nameof(valuemember));
            }

            l.DataSource = bs;
            l.DisplayMember = displaymember;
            l.ValueMember = valuemember;


        }

        static public void remplir_Grille(DataGridView v, BindingSource bs)
        {
            if (bs is null)
            {
                throw new ArgumentNullException(nameof(bs));
            }

            v.DataSource = bs;


        }


        static public void syncroniser(string table)
        {
            if (string.IsNullOrEmpty(table))
            {
                throw new ArgumentException("message", nameof(table));
            }

            SqlDataAdapter da = new SqlDataAdapter("select * from " + table, cn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds.Tables[table]);
            da = null;
            cb = null;


        }

        





    }



}

