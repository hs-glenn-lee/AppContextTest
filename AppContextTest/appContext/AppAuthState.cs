using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppContextTest.appContext
{

    class AppStateMessage
    {
        public const String INITIAL = "INITIAL";
        public const String AUTHENTICATING = "AUTHENTICATING";
        public const String AUTHORIZED = "AUTHORIZED";
        public const String UNAUTHORIZED = "UNAUTHORIZED";
        public const String NEED_TO_ACTIVATE_NEW = "NEED_TO_ACTIVATE_NEW";
        public const String DISCONNECTED = "DISCONNECTED";
    }

    public interface AppAuthState
    {
        void authenticate(AppAuthContext context);
        void authorize(AppAuthContext context);
        void authenticateActivatingNew(AppAuthContext context);
        void unauthorize(AppAuthContext context);
        void disconnect(AppAuthContext context);
        String getMessage();
    }

    public class IntialState : AppAuthState
    {
        void AppAuthState.authenticate(AppAuthContext context)
        {
            Login loginForm = context.getLoginForm();
            loginForm.setStateMessage("로그인 시도하고 있습니다.");
        }

        void AppAuthState.authenticateActivatingNew(AppAuthContext context)
        {
            throw new NotImplementedException();
        }

        void AppAuthState.authorize(AppAuthContext context)
        {
            throw new NotImplementedException();
        }

        void AppAuthState.disconnect(AppAuthContext context)
        {
            throw new NotImplementedException();
        }

        string AppAuthState.getMessage()
        {
            return AppStateMessage.INITIAL;
        }

        void AppAuthState.unauthorize(AppAuthContext context)
        {
            throw new NotImplementedException();
        }
    }

    public class AuthenticatingState : AppAuthState
    {
        void AppAuthState.authenticate(AppAuthContext context)
        {
            throw new NotImplementedException();
        }

        void AppAuthState.authenticateActivatingNew(AppAuthContext context)
        {
            throw new NotImplementedException();
        }

        void AppAuthState.authorize(AppAuthContext context)
        {
            Login loginForm = context.getLoginForm();
            loginForm.setStateMessage("로그인 되었습니다.");
        }

        void AppAuthState.disconnect(AppAuthContext context)
        {
            throw new NotImplementedException();
        }

        string AppAuthState.getMessage()
        {
            return AppStateMessage.AUTHENTICATING;
        }

        void AppAuthState.unauthorize(AppAuthContext context)
        {
            throw new NotImplementedException();
        }
    }

    public class AuthorizedState : AppAuthState
    {
        void AppAuthState.authenticate(AppAuthContext context)
        {
            throw new NotImplementedException();
        }

        void AppAuthState.authenticateActivatingNew(AppAuthContext context)
        {
            throw new NotImplementedException();
        }

        void AppAuthState.authorize(AppAuthContext context)
        {
            throw new NotImplementedException();
        }

        void AppAuthState.disconnect(AppAuthContext context)
        {
            throw new NotImplementedException();
        }

        string AppAuthState.getMessage()
        {
            return AppStateMessage.AUTHORIZED;
        }

        void AppAuthState.unauthorize(AppAuthContext context)
        {
            throw new NotImplementedException();
        }
    }
}
