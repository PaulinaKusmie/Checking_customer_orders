using DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

        PobierzDaneZamowienia(DropDownList1.SelectedItem.Text);
    }

    protected void PobierzDaneZamowienia(string idKlienta)
    {
        DataSet mojZbiorDanych = new DataSet();
        CustomersTableAdapter klientDA = new CustomersTableAdapter();
        OrdersTableAdapter zamowieniaDA = new OrdersTableAdapter();

        klientDA.Fill(mojZbiorDanych.Customers, idKlienta);
        zamowieniaDA.Fill(mojZbiorDanych.Orders, idKlienta);

        GridView1.DataSource = mojZbiorDanych.Tables["Customers"];
        GridView1.DataBind();

        GridView2.DataSource = mojZbiorDanych.Tables["Orders"];
        GridView2.DataBind();


    }
}