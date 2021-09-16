﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Models;
using System.IO;

namespace DataAccessLibrary
{
    public class TextFileDataAccess
    {
        public List<ContactModel> ReadAllRecords(string textFile)
        {
            if (File.Exists(textFile)==false)
            {
                return new List<ContactModel>();
            }


            var lines = File.ReadAllLines(textFile);
            List<ContactModel> output = new List<ContactModel>();

            foreach(var line in lines)
            {
                ContactModel c = new ContactModel();
                var vals = line.Split(',');
                if(vals.Length<4)
                {
                    throw new Exception($"Invalid row of data:{line}");
                }
                c.FirstName = vals[0];
                c.LastName = vals[1];
                c.EmailAddresses = vals[2].Split(';').ToList();
                c.PhoneNumbers = vals[3].Split(';').ToList();

                output.Add(c);
            }
            return output;

        }
        public void WriteAllRecords(List<ContactModel> contacts, string textFile)
        {
            List<string> lines = new List<string>();
            foreach (var c in contacts)
            {
                lines.Add($"{ c.FirstName},{ c.LastName},{string.Join(';', c.EmailAddresses)},{string.Join(';', c.PhoneNumbers)}");
            }

            File.WriteAllLines(textFile, lines);

        }
    }
}
