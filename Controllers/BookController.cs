using System;
using System.Collections.Generic;
using libraryapi.FAKEDB;
using libraryapi.Models;
using libraryapi.Services;
using Microsoft.AspNetCore.Mvc;

namespace libraryapi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]

    public class BookController : ControllerBase
    {

        private readonly BooksService _service;

        public BookController(BooksService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetAll()
        {
            try
            {
                return Ok(_service.Get());

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("available")]
        public ActionResult<IEnumerable<Book>> GetAvail()
        {
            try
            {
                return Ok(_service.Get());
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Book> GetById(string id)
        {
            try
            {
                return Ok(_service.GetById(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]

        public ActionResult<Book> Create([FromBody] Book newBook)
        {
            try
            {
                return Ok(_service.Create(newBook));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]

        public ActionResult<Book> Edit([FromBody] Book editBook, string id)
        {
            try
            {
                return Ok(_service.Edit(editBook, id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{bookId}")]
        public ActionResult<Book> Delete(string bookId)
        {
            try
            {
                return Ok(_service.Delete(bookId));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}