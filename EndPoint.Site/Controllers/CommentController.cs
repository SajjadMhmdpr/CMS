using Application;
using Domain.News;
using EndPoint.Site.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.Site.Controllers
{
    public class CommentController : Controller
    {
        private UnitOfWork _context;
        public CommentController()
        {
            _context = new UnitOfWork();

        }

        [HttpGet]
        public IActionResult GetComment(int id)
        {

           
            return PartialView("_CommentListPartialView", _context.Page.getByID(id).Comments);

        }

        [HttpPost]
        public IActionResult SetComment(CommentViewModel comment)
        {

            _context.Comment.insert(new Comment
            {
                PageId = comment.PageId,
                Text = comment.Text,
                Name = comment.Name,
                Email = comment.Email,
                CreateDate = DateTime.Now
            });
            _context.Comment.save();
            return PartialView("_CommentListPartialView",_context.Page.getByID(comment.PageId).Comments);

        }

        //[HttpPost]
        //public IActionResult SetComment(CommentViewModel comment)
        //{

        //    _context.Comment.insert(new Comment {
        //        PageId = comment.PageId,
        //        Text = comment.Text,
        //        Name = comment.Name,
        //        Email = comment.Email,
        //        CreateDate = DateTime.Now
        //    });
        //    _context.Comment.save();
        //    return RedirectToAction("GetPage","Page", new { id = comment.PageId });

        //}
    }
}
