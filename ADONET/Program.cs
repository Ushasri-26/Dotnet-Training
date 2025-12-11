using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment ob = new Assignment();
            //Console.WriteLine("enter start date");
            //DateTime d1 = Convert.ToDateTime(Console.ReadLine());
            //Console.WriteLine("enter end date");
            //DateTime d2 = Convert.ToDateTime(Console.ReadLine());
            //ob.GetTransactions(d1, d2);
            //Console.WriteLine("enter id:");
            //int id=Convert.ToInt32(Console.ReadLine());
            //ob.GetCommonRecords(id);
            //ob.InsertRecordsusingtrans();
            //ob.InsertAndFetchIdentity();
            //ob.ShowEmployeesAndDepartments();
            //ob.Getdetails();
            //ob.CloseConnection();
            //Disconnected ob = new Disconnected();
            //ob.ShowAllRecords();
            //ob.FilterEmployee();
            //ob.ShowTotalTables();
            //ob.CopyTable();
            //ob.ShowCustomerOrders();
            //ob.ReadXmlData();
            Linqdemo ob = new Linqdemo();
            ob.MoviesbyPrabhas();
            ob.MovieRelease();
            ob.MWPA();
            ob.ActressWP();
            ob.Movies10to18();
            ob.Sortbyyear();
            ob.MaxMovies();
            ob.Movieslen();
            ob.Movierel();
            ob.StartsBEndsI();
            ob.ANWR();
            ob.MovieCast();
            //Products
            ProductsDemo p = new ProductsDemo();
            p.SecHighest();
            p.Top3High();
            p.SumOfPrice();
            p.ProdEndI();
            p.GrpByQty();
            p.SumOfProdPrice();
            p.PriceGreaterThan5000();
            //Arrays
            Arrays a = new Arrays();
            a.UniqueVal();
            a.WithoutDup();
            a.CommonItems();
            a.NameinANotinB();
            a.HighestVal();
            a.divby3();
            a.StrLength();
        }

    }
}

