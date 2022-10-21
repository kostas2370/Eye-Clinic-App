﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ofthalmiatrio
{
    internal class DatabaseDev
    {

        private static SQLiteConnection conn;
        private static SQLiteCommand sqlite_cmd;
        /*
         we create the connection of the db
        and it returns sqliteconnection we need for the other functions
         
         */
        public static void createDb()
        {


           
            conn = new SQLiteConnection("Data Source = database.db; Version = 3; New = True; Compress = True; ");
            conn.Open();
            
           
        }

        /*
         
         We create and set up the db tables 
          the parammeter is to get the connection
         
         */

        public static void CreateTables()
        {
             sqlite_cmd = conn.CreateCommand();



            sqlite_cmd.CommandText = "CREATE TABLE IF NOT EXISTS astheneis(AMKA VARCHAR(11) PRIMARY KEY,OnomaTeponimo VARCHAR(40) NOT NULL,Asfaleia VARCHAR(20) NOT NULL,Xrhmatiko_Poso INT,Episkepseis INT NOT NULL)"; ;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "CREATE TABLE IF NOT EXISTS rantevou(id INTEGER PRIMARY KEY,AMKA VARCHAR(11),hmerominia Text NOT NULL,myopia_aristero REAL,myopia_dexio REAL,presviopia_aristero REAL,presviopia_dexio REAL,ypermatropia_aristero REAL,ypermatropia_dexio REAL,astigmatismos_aristero REAL,astigmatismos_dexio REAL,piesh_aristero REAL,piesh_dexio REAL,asthenia TEXT,therapia TEXT,farmaka TEXT,diarkeia_therapeias INT,Apotelesmata TEXT,FOREIGN KEY(AMKA) REFERENCES astheneis(AMKA) ) "; ;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "CREATE TABLE IF NOT EXISTS medicine(id INTEGER PRIMARY KEY,onoma TEXT NOT NULL UNIQUE,typos TEXT NOT NULL,symptomata TEXT,promitheftes TEXT)";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "CREATE TABLE IF NOT EXISTS user(id INTEGER PRIMARY KEY,username VARCHAR(12) NOT NULL UNIQUE,password VARCHAR(15) NOT NULL,role TEXT DEFAULT 'No role') "; ;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO user(username,password,role) VALUES('admin','admin','admin')"; ;
            sqlite_cmd.ExecuteNonQuery();
        }


        /* 
         we get 2 parameters , username and password 
         both of them are strings

         it returns an sqlite reader with the role of the user .
        
         */
        public static SQLiteDataReader Login( string username, string password)
        {
            sqlite_cmd = conn.CreateCommand();
            
            string logincomm = $"SELECT role FROM user WHERE username= '{username}' AND password='{password}'";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = logincomm;
            sqlite_cmd.CommandType = CommandType.Text;
            SQLiteDataReader myReader = sqlite_cmd.ExecuteReader();


            return myReader;




        }
        // add patient
        public static Boolean addPatient( string AMKA, string OnomaTeponimo, string Asfaleia, int xrhmatiko_poso = 0, int episkepseis = 0)
        {
             sqlite_cmd = conn.CreateCommand();
            string addpat = $"INSERT INTO astheneis(AMKA,OnomaTeponimo,Asfaleia,Xrhmatiko_Poso,Episkepseis) VALUES('{AMKA}','{OnomaTeponimo}','{Asfaleia}',{xrhmatiko_poso},{episkepseis})";
            sqlite_cmd.CommandText = addpat;
            int j = 0;
            try
            {
                j = sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("This amka already exists");
                return false;
            }

            if (j >= 1)
            {
                return true;
            }
            return false;

        }
        public static Boolean addVisit(string AMKA, string visit_date, string myopia_aristero, string myopia_dexio, string presviopia_aristero, string presviopia_dexio, string ypermetropia_aristero, string ypermetropia_dexio, string astigmatismos_aristero, string astigmatismos_dexio, string piesh_aristero, string piesh_dexio, string astheneia, string therapeia, string farmaka, string diarkeia, string kostos)
        {
             sqlite_cmd = conn.CreateCommand();
            string addvis = $"INSERT INTO rantevou(AMKA,hmerominia,myopia_aristero,myopia_dexio,presviopia_aristero,presviopia_dexio,ypermatropia_aristero,ypermatropia_dexio,astigmatismos_aristero,astigmatismos_dexio,piesh_aristero,piesh_dexio,asthenia,therapia,farmaka,diarkeia_therapeias) VALUES('{AMKA}','{visit_date}',{myopia_aristero},{myopia_dexio},{presviopia_aristero},{presviopia_dexio},{ypermetropia_aristero},{ypermetropia_dexio},{astigmatismos_aristero},{astigmatismos_dexio},{piesh_aristero},{piesh_dexio},'{astheneia}','{therapeia}','{farmaka}',{diarkeia})";
            string update_astheneis = $"UPDATE astheneis SET Episkepseis = Episkepseis+1, Xrhmatiko_Poso=Xrhmatiko_Poso+{kostos} WHERE AMKA='{AMKA}'";
            sqlite_cmd.CommandText = addvis;
            int j = sqlite_cmd.ExecuteNonQuery();
            if (j > 0)
            {

                sqlite_cmd.CommandText = update_astheneis;
                sqlite_cmd.ExecuteNonQuery();
                return true;
            }

            return false;
        }
        public static SQLiteDataReader getAMKAS()
        {
             sqlite_cmd = conn.CreateCommand();
            string getamkas = "SELECT AMKA FROM astheneis";
            sqlite_cmd.CommandText = getamkas;
            sqlite_cmd.CommandType = CommandType.Text;
            SQLiteDataReader myReader = sqlite_cmd.ExecuteReader();
            return myReader;


        }

        public static SQLiteDataReader getAstheneis(String input, string mode = "AMKA")
        {
             sqlite_cmd = conn.CreateCommand();
            string getPats = $"SELECT * FROM astheneis WHERE {mode} = '{input}'";
            sqlite_cmd.CommandText = getPats;
            sqlite_cmd.CommandType = CommandType.Text;
            SQLiteDataReader myReader = sqlite_cmd.ExecuteReader();
            return myReader;

        }

        public static SQLiteDataReader getRantevou( string AMKA,string id=null)
        {
             sqlite_cmd = conn.CreateCommand();
            
            string getRant= $"SELECT * FROM rantevou WHERE AMKA = {AMKA} ORDER BY date(hmerominia)";
            if (!(id is null))
            {
                getRant = $"SELECT * FROM rantevou WHERE id = {id} ORDER BY date(hmerominia)";

            }
            
            sqlite_cmd.CommandText = getRant;
            sqlite_cmd.CommandType = CommandType.Text;
            SQLiteDataReader myReader = sqlite_cmd.ExecuteReader();
            return myReader;

        }
        public static SQLiteDataReader getLastRantevou( string AMKA)
        {
             sqlite_cmd = conn.CreateCommand();
            string getLast = $"SELECT * FROM rantevou WHERE AMKA = {AMKA} ORDER BY date(hmerominia) DESC LIMIT 1";
            sqlite_cmd.CommandText = getLast;
            sqlite_cmd.CommandType = CommandType.Text;
            SQLiteDataReader myReader = sqlite_cmd.ExecuteReader();
            return myReader;
        }
        public static bool update_apotelesma(string id, string apotelesmata)
        {
             sqlite_cmd = conn.CreateCommand();
            string addapotelesmata = $"UPDATE rantevou SET Apotelesmata='{apotelesmata}' WHERE id = {id}";
            sqlite_cmd.CommandText = addapotelesmata;
            int j = sqlite_cmd.ExecuteNonQuery();
            if (j > 0)
            {
                return true;
            }
            return false;

        }

        public static bool updateAstheneis(string AMKA,string OnomaTeponymo,string asfaleia)
        {
             sqlite_cmd = conn.CreateCommand();
            string editAstheneis = $"UPDATE astheneis SET OnomaTeponimo='{OnomaTeponymo}',Asfaleia='{asfaleia}' WHERE AMKA = {AMKA}";
            sqlite_cmd.CommandText = editAstheneis;
            int j = sqlite_cmd.ExecuteNonQuery();

            if (j > 0)
            {
                return true;
            }
            return false;

        }

        public static bool deleteRantevou(string id,string AMKA)
        {
            sqlite_cmd = conn.CreateCommand();
            string deleteRantevou = $"DELETE FROM rantevou WHERE id = {id}";

            string update_astheneis = $"UPDATE astheneis SET Episkepseis = Episkepseis-1  WHERE AMKA='{AMKA}'";

            sqlite_cmd.CommandText = deleteRantevou;
            int j = sqlite_cmd.ExecuteNonQuery();
            if (j == 1)
            {
                sqlite_cmd.CommandText = update_astheneis;
                sqlite_cmd.ExecuteNonQuery();
                return true;

            }
            
            return false;


        }


        public static bool updateRantevou(string id,  string myopia_aristero, string myopia_dexio, string presviopia_aristero, string presviopia_dexio, string ypermetropia_aristero, string ypermetropia_dexio, string astigmatismos_aristero, string astigmatismos_dexio, string piesh_aristero, string piesh_dexio, string astheneia, string therapeia, string farmaka, string diarkeia,string apot)
        {
            sqlite_cmd = conn.CreateCommand();
            string editVisit = $"UPDATE rantevou SET myopia_aristero={myopia_aristero},myopia_dexio={myopia_dexio},presviopia_aristero={presviopia_aristero},presviopia_dexio={presviopia_dexio},ypermatropia_aristero={ypermetropia_aristero},ypermatropia_dexio={ypermetropia_dexio},piesh_aristero={piesh_aristero},piesh_dexio={piesh_dexio},asthenia='{astheneia}',therapia='{therapeia}',farmaka='{farmaka}',diarkeia_therapeias={diarkeia},Apotelesmata='{apot}' WHERE id = {id}";
            sqlite_cmd.CommandText = editVisit;
            int j = sqlite_cmd.ExecuteNonQuery();
            if (j > 1)
            {
                return true;

            }

            return false;


        }


    











        public static string addMedicine(string onoma,string typos,string symptomata,string promitheftis)
        {


            sqlite_cmd = conn.CreateCommand();
            string addMed = $"INSERT INTO medicine(onoma,typos,symptomata,promitheftes) VALUES('{onoma}','{typos}','{symptomata}','{promitheftis}') ";
            sqlite_cmd.CommandText = addMed;
            int j = sqlite_cmd.ExecuteNonQuery();
            if (j == 1)
            {
                string getID = "SELECT * FROM medicine ORDER BY id DESC LIMIT 1";
                sqlite_cmd.CommandText = getID;
                sqlite_cmd.CommandType = CommandType.Text;
                SQLiteDataReader myReader = sqlite_cmd.ExecuteReader();
                myReader.Read();
                return myReader["id"].ToString();
                
                

            }

            return null;



           
        }
        public static SQLiteDataReader getMedicine(string id=null)
        {
            sqlite_cmd = conn.CreateCommand();


            string getMedicine = "SELECT * FROM medicine";
            if (!(id is null))
            {
                getMedicine = $"SELECT * FROM medicine WHERE id ={id}";
            }
            sqlite_cmd.CommandText = getMedicine;
            sqlite_cmd.CommandType = CommandType.Text;
            SQLiteDataReader myReader = sqlite_cmd.ExecuteReader();
            return myReader;
        }

        public static bool deleteMedicine(string id)
        {
            sqlite_cmd = conn.CreateCommand();
            string delMedicine = $"DELETE FROM medicine WHERE id = {id}";
            sqlite_cmd.CommandText = delMedicine;
            int j = sqlite_cmd.ExecuteNonQuery();
            if (j == 1)
            {
                return true;

            }

            return false;

        }public static bool updateMedicine(string id, string onoma, string typos, string symptomata, string promitheftis)
        {
            sqlite_cmd=conn.CreateCommand();
            string updateMed = $"UPDATE medicine SET onoma='{onoma}',typos='{typos}',symptomata='{symptomata}',promitheftes='{promitheftis}' WHERE id={id}";
            sqlite_cmd.CommandText=updateMed;
            int j =sqlite_cmd.ExecuteNonQuery();
            if (j == 1)
            {
        
                return true;
            }
            return false;
           
        }


        
        }





    }

//id INTEGER PRIMARY KEY,onoma TEXT NOT NULL UNIQUE,authentikotita NOT NULL,symptomata TEXT,promithefths TEXT