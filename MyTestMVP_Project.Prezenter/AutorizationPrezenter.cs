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
            _view.EnterPassword += _view_EnterPassword;
        }

        private void _view_EnterPassword(object sender, EventArgs e)
        { 
            try
            {
                var content = _bl.AuthorizationPasswor(_view.Passwor);
                _view.PrintMessage(content);
            }
            catch (Exception ex)
            {
                _view.PrintMessage(ex.ToString());
            }
        }
    }
}
