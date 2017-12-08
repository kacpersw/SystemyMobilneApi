using RoomReservation.Interfaces;
using RoomReservation.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public void AddReservation(Reservation reservation)
        {
            _db.Entry(reservation).State = EntityState.Added;
            _db.SaveChanges();
        }

        public void RemoveReservation(int id)
        {
            Reservation reservation = _db.Reservation.Where(r => r.Id == id).FirstOrDefault();

            _db.Entry(reservation).State = EntityState.Deleted;
            _db.SaveChanges();
        }

        public IEnumerable<Reservation> GetAllReservations()
        {
            return _db.Reservation.ToList();
        }

        public IEnumerable<Reservation> GetReservationsByRoomId(int id)
        {
            return _db.Reservation
                .Where(r => r.RoomId == id)
                .ToList();
        }

        public void EditReservation(Reservation reservation)
        {
            _db.Entry(reservation).State = EntityState.Modified;
            _db.SaveChanges();
        }
    }
}