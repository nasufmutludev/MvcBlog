using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CommentManager:ICommentService
    {
        private ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public List<Comment> ListAllComment()
        {
            return _commentDal.GetAll();
        }

        public void AddComment(Comment comment)
        {
            _commentDal.Add(comment);
        }

        public void DeleteComment(Comment comment)
        {
            _commentDal.Delete(comment);
        }

        public void UpdateComment(Comment comment)
        {
            _commentDal.Update(comment);
        }

        public Comment GetById(int id)
        {
            return _commentDal.Get(x => x.Id == id);
        }
    }
}
