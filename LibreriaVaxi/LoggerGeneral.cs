﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaVaxi
{
    public interface ILoggerGeneral
    {
        void Message(string message);
        bool LogDatabase(string message);
        bool LogBalanceDespuesRetiro(int balanceDespuesRetiro);
        string MessageConReturnStr(string message);
        bool MessageConOutParametroReturnBoolean(string str, out string outputStr);
    }

    public class LoggerGeneral : ILoggerGeneral
    {
        public bool LogBalanceDespuesRetiro(int balanceDespuesRetiro)
        {
            if(balanceDespuesRetiro >= 0)
            {
                Console.WriteLine("exito");
                return true;
            }

            Console.WriteLine("error");
            return false;
        }

        public bool LogDatabase(string message)
        {
            Console.WriteLine(message);
            return true;
        }

        public void Message(string message)
        {
            Console.WriteLine(message);
        }

        public bool MessageConOutParametroReturnBoolean(string str, out string outputStr)
        {
            outputStr = "Hola" + str;
            return true;
        }

        public string MessageConReturnStr(string message)
        {
            Console.WriteLine(message);
            return message.ToLower();
        }
    }

    public class LoggerFake : ILoggerGeneral
    {
        public bool LogBalanceDespuesRetiro(int balanceDespuesRetiro)
        {
            return false;
        }

        public bool LogDatabase(string message)
        {
            return false;
        }

        public void Message(string message)
        {
        }

        public bool MessageConOutParametroReturnBoolean(string str, out string outputStr)
        {
            outputStr = string.Empty;
            return false;
        }

        public string MessageConReturnStr(string message)
        {
            return message;
        }
    }
}
