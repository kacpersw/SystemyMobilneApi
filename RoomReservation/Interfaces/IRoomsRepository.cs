using RoomReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Interfaces
{
    public interface IRoomsRepository
    {
        void AddRoom(Room room);
        void RemoveRoom(int id);
        IEnumerable<Room> GetAllRooms();
    }
}
