using RoomReservation.Interfaces;
using RoomReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoomReservation.Repository
{
    public class ReservationsRepository : IReservationsRepository
    {
        private readonly ReservationDatabaseEntities _db;

        public ReservationsRepository(ReservationDatabaseEntities db)
        {
            _db = db;
        }
    }
}