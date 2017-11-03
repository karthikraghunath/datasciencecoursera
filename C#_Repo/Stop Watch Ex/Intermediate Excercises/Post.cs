using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_Excercises
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        private int noofupvotes;
        private int noofdownvotes;

        public void upvotes(int upvote)
        {
            noofupvotes += upvote;
            
        }

        public void downvotes(int downvote)
        {
            noofdownvotes += downvote;

        }

        public int currentvotes()
        {
            var noofvotes = noofupvotes - noofdownvotes;
            return (noofvotes);
        }
    }
}
