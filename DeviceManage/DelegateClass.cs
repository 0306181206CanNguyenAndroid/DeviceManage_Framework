using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceManage
{
    public delegate void FireEventForActionDevicesSuccess(object sender, ActionDevicesSuccessEventArgs e);
    public delegate void FireEventForActionAccountsSuccess(object sender, ActionAccountsSuccessEventArgs e);
    public delegate void FireEventForAction_RequestDevices(object sender, RequestDevicesSuccessEventArgs e);
    public delegate void FireEventForAction_RequestEmplyeesManage(object sender, RequestEmplyeesManageSuccessEventArgs e);
    public delegate void FireEventForAction_LogoutSuccess(object sender, Action_LogoutSuccessEventArgs e);
    
    public class Action_LogoutSuccessEventArgs : EventArgs
    {

    }

    public class ActionDevicesSuccessEventArgs : EventArgs
    {
        
    }
    public class ActionAccountsSuccessEventArgs : EventArgs
    {

    }

    public class RequestDevicesSuccessEventArgs : EventArgs
    {

    }

    public class RequestEmplyeesManageSuccessEventArgs
    {
    }

    #region Manage Specs
    public delegate void FireEventFor_Action_AddSpecsForDeviceTypeEventArgs(object sender, Action_AddSpecsForDeviceTypeEventArgs e);
    public class Action_AddSpecsForDeviceTypeEventArgs : EventArgs
    {

    }

    #endregion
}
