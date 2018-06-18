﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Globalization;

namespace QuanLyHocSinh.DAO
{
    public class DataProvider


    {

        private static DataProvider instance; //Đóng gói (Ctrl+R+E)


        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set => instance = value; //Nội bộ Class dùng
        }

        private DataProvider() { }//Hàm dựng


        private string connectionSTR = "Data Source=DESKTOP-5AT0CKE;Initial Catalog=QuanLyHocSinh;Integrated Security=True";

        public DataTable ExcuteQuery(string query, object[] parameter = null)

        {
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionSTR))//Sử dụng using đê giải phóng bộ nhớ
            {
                conn.Open(); //Mở kết nối

                SqlCommand command = new SqlCommand(query, conn);//Tạo command
                command.CommandType = CommandType.StoredProcedure;

                if (parameter != null)
                {
                    string[] temp = query.Split(' ');

                    List<string> listPar = new List<string>();

                    foreach (string item in temp)
                    {
                        if (item != string.Empty && item[0] == '@')
                            listPar.Add(item);
                    }

                    for (int i = 0; i < parameter.Length; i++)
                    {
                        command.Parameters.AddWithValue(listPar[i], parameter[i]);
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                conn.Close();
            }

            return data;
        }
        public DataTable ExcuteQuery1(string query, object[] parameter = null)

        {
            string connectionSTR = "Data Source=DESKTOP-5AT0CKE;Initial Catalog=QuanLyHocSinh;Integrated Security=True";
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionSTR))//Sử dụng using đê giải phóng bộ nhớ
            {
                conn.Open(); //Mở kết nối

                SqlCommand command = new SqlCommand(query, conn);//Tạo command

                if (parameter != null)
                {
                    string[] ListPar = query.Split(' ');
                    int i = 0;
                    foreach (string item in ListPar)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;

                        }

                    }
                }



                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                conn.Close();
            }

            return data;
        }

        public int ExcuteNonQuery(string query, object[] parameter = null)//Trả số dòng insert thành công

        {
            int data = 0;
            using (SqlConnection conn = new SqlConnection(connectionSTR))//Sử dụng using đê giải phóng bộ nhớ
            {
                conn.Open(); //Mở kết nối

                SqlCommand command = new SqlCommand(query, conn);//Tạo command
                


                
                if (parameter != null)
                {
                    string[] temp = query.Split(' ');

                    List<string> listPar = new List<string>();

                    foreach (string item in temp)
                    {
                        if (item !=string.Empty && item[0] == '@')
                            listPar.Add(item);
                    }

                    for (int i = 0; i < parameter.Length; i++)
                    {
                        command.Parameters.AddWithValue(listPar[i], parameter[i]);
                    }
                }


                data = command.ExecuteNonQuery();


                conn.Close();
            }

            return data;
        }
        public int ExcuteNonQuery1(string query, object[] parameter = null)//Trả số dòng insert thành công

        {
            int data = 0;
            using (SqlConnection conn = new SqlConnection(connectionSTR))//Sử dụng using đê giải phóng bộ nhớ
            {
                conn.Open(); //Mở kết nối

                SqlCommand command = new SqlCommand(query, conn);//Tạo command
                


                //command.CommandType = commandType;
                if (parameter != null)
                {
                    string[] ListPar = query.Split(' ');
                    int i = 0;
                    foreach (string item in ListPar)
                    {
                        if (item.Contains('@'))
                        {

                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;


                        }

                    }
                }


                data = command.ExecuteNonQuery();


                conn.Close();
            }

            return data;
        }
        public object ExcuteScalar(string query, object[] parameter = null)

        {
            object data = 0;
            using (SqlConnection conn = new SqlConnection(connectionSTR))//Sử dụng using đê giải phóng bộ nhớ
            {
                conn.Open(); //Mở kết nối

                SqlCommand command = new SqlCommand(query, conn);//Tạo command

                if (parameter != null)
                {
                    string[] ListPar = query.Split(' ');
                    int i = 0;
                    foreach (string item in ListPar)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;

                        }

                    }
                }

                data = command.ExecuteScalar();
                conn.Close();
            }

            return data;
        }
        public object ExcuteScalar1(string query, object[] parameter = null)

        {
            object data = 0;
            using (SqlConnection conn = new SqlConnection(connectionSTR))//Sử dụng using đê giải phóng bộ nhớ
            {
                conn.Open(); //Mở kết nối

                SqlCommand command = new SqlCommand(query, conn);//Tạo command

                if (parameter != null)
                {
                    string[] temp = query.Split(' ');

                    List<string> listPar = new List<string>();

                    foreach (string item in temp)
                    {
                        if (item != string.Empty && item[0] == '@')
                            listPar.Add(item);
                    }

                    for (int i = 0; i < parameter.Length; i++)
                    {
                        command.Parameters.AddWithValue(listPar[i], parameter[i]);
                    }
                }

                data = command.ExecuteScalar();
                conn.Close();
            }

            return data;
        }
    }
}
