﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class CounterState
    {
        int _count = 0;
        public int Count 
        { 
            get
            {
                return _count;
            }
            set 
            {
                _count = value;
                Refresh();
            } 
        }

        public Action OnStateChanged;

        void Refresh()
        {
            OnStateChanged?.Invoke();
        }
    }
}
