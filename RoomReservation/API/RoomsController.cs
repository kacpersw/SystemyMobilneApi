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
    public class RoomsController : ApiController
    {
        private readonly IRoomsRepository _repository;

        public RoomsController(IRoomsRepository repository)
        {
            _repository = repository;
        }

        public IHttpActionResult GetAllRooms()
        {
            return Ok(_repository.GetAllRooms());
        }

        public IHttpActionResult DeleteRoom(int id)
        {
            _repository.RemoveRoom(id);

            return Ok();
        }

        public IHttpActionResult InsertRoom(Room room)
        {
            _repository.AddRoom(room);

            return Ok();
        }
    }
}
