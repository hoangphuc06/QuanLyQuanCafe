﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuanCafe.DTO;
using System.Data;

namespace QuanLyQuanCafe.DAO
{
    class ResourceDAO
    {
        public static ResourceDAO instance;

        public static ResourceDAO Instance {
            get { if (instance == null) instance = new ResourceDAO();return ResourceDAO.instance;}
            private set { ResourceDAO.instance = value; }
        }

        private ResourceDAO() { }

        public List<Resource> GetListResource()
        {
            List<Resource> list = new List<Resource>();
            string query = "select * from Resources";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Resource res = new Resource(item);
                list.Add(res);
            }
            return list;
        }

        public List<Resource> GetResourceByMonth(int month,int year)
        {
            List<Resource> list = new List<Resource>();
            string query = string.Format("select * from Resources where MONTH(DayIn) = {0} AND YEAR(DayIn) = {1}",month,year);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Resource res = new Resource(item);
                list.Add(res);
            }
            return list;
        }
        public bool InsertResource(string id,string resourcename,float price,string dayin,string unit,int amount,string username)
        {
            string query = string.Format("insert into Resources values(N'{0}', N'{1}',{2},'{3}', N'{4}',{5}, N'{6}')", id, resourcename, price, dayin, unit, amount, username);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateResource(string id, string resourcename, float price, string dayin, string unit, int amount, string username)
        {
            string query = string.Format("update Resources set RName = N'{0}',Price = {1},DayIn = '{2}',Unit = N'{3}',Amount = {4},UserName = N'{5}'	where ID_Resource = N'{6}'",resourcename, price, dayin, unit, amount, username,id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteResource(string id)
        {
            string query = string.Format("delete Resources where ID_Resource = N'{0}'",id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}