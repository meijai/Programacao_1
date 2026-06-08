using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Room
    {
        public int Id { get; set; }
        public RoomType? RoomType { get; set; }
        public int RoomNumber { get; set; }
    }
    public enum RoomType
    {
        Bedroom,
        Bathroom,
        Kitchen,
        LivingRoom,
        DiningRoom,
        Office,
        Garage,
        Other
    }
}
