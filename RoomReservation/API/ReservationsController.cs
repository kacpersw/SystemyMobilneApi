using RoomReservation.Interfaces;
using RoomReservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RoomReservation.API
{
    public class ReservationsController : ApiController
    {
        private readonly IReservationsRepository _repository;

        public ReservationsController(IReservationsRepository repository)
        {
            _repository = repository;
        }

        public IHttpActionResult GetAllReservations()
        {
            return Ok(_repository.GetAllReservations());
        }

        public IHttpActionResult GetReservationsByRoomId(int id)
        {
            return Ok(_repository.GetReservationsByRoomId(id));
        }

        public IHttpActionResult DeleteReservation(int id)
        {
            _repository.RemoveReservation(id);

            return Ok();
        }

        public IHttpActionResult InsertReservation(Reservation reservation)
        {
            _repository.AddReservation(reservation);

            return Ok();
        }

        public IHttpActionResult PutReservation(Reservation reservation)
        {
            _repository.EditReservation(reservation);

            return Ok();
        }
    }
}
