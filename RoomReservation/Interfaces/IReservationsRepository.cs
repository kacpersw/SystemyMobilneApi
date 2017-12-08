using RoomReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Interfaces
{
    public interface IReservationsRepository
    {
        void AddReservation(Reservation reservation);
        void RemoveReservation(int id);
        IEnumerable<Reservation> GetAllReservations();
        IEnumerable<Reservation> GetReservationsByRoomId(int id);
        void EditReservation(Reservation reservation);
    }
}
