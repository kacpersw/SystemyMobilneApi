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
    }
}