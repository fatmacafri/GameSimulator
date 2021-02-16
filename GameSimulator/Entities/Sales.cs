using GameSimulator.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulator.Entities
{
    class Sales:IEntity
    {
        public int Id { get; set; }
        public string Game { get; set; }
        public string Gamer { get; set; }
    }
}
