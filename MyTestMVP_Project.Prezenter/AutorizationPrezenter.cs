using MyTestMVP_Project.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestMVP_Project.Prezenter
{
    public class AutorizationPrezenter
    {
        private IAuthorization _bl;
        private IViewInterface _view;

        public AutorizationPrezenter(IViewInterface view , IAuthorization bl )
        {
            _bl = bl;
            _view = view;

        }


    }
}
