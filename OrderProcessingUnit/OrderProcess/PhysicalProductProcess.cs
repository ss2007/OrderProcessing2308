﻿using OrderProcessingUnit.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingUnit.OrderProcess
{
    public class PhysicalProductProcess : IProcess
    {
        
        public void process()
        {
            Console.WriteLine("generate a packing slip for shipping.");
            OnGenerateCommision(EventArgs.Empty);
        }

        protected virtual void OnGenerateCommision(EventArgs e)
        {
            EventHandler handler = GenerateCommision;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        IList<string> IProcess.process()
        {
            throw new NotImplementedException();
        }

        public event EventHandler GenerateCommision;
    }
}