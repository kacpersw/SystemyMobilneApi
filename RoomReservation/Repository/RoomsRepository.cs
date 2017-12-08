using RoomReservation.Interfaces;
using RoomReservation.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RoomReservation.Repository
{
    public class RoomsRepository : IRoomsRepository
    {
        private readonly ReservationDatabaseEntities _db;

        public RoomsRepository(ReservationDatabaseEntities db)
        {
            _db = db;
        }

        public void AddRoom(Room room)
        {
            _db.Entry(room).State = EntityState.Added;
            _db.SaveChanges();
        }

        public void RemoveRoom(int id)
        {
            Room room = _db.Room.Where(r => r.Id == id).FirstOrDefault();

            _db.Entry(room).State = EntityState.Deleted;
            _db.SaveChanges();
        }

        public IEnumerable<Room> GetAllRooms()
        {
            return _db.Room.ToList();
        }
    }
}