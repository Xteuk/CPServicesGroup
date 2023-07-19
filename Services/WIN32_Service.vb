Imports System.Collections.Generic
Imports System.Management

Public Class WIN32_Service
    Inherits WIN32_ManagedItem

    Public Sub New()
        MyBase.New(Nothing)
    End Sub

    Public Sub New(ByVal mo As ManagementObject)
        MyBase.New(mo)
    End Sub

    ''' <summary>
    ''' Service can be paused.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property AcceptPause As Boolean
        Get
            Return ManagementObject("AcceptPause")
        End Get
    End Property

    ''' <summary>
    ''' Service can be stopped.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property AcceptStop As Boolean
        Get
            Return ManagementObject("AcceptStop")
        End Get
    End Property

    ''' <summary>
    ''' Short description of the object—a one-line string.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Caption As String
        Get
            Return ManagementObject("Caption")
        End Get
    End Property

    ''' <summary>
    ''' Value that the service increments periodically to report its progress 
    ''' during a long start, stop, pause, or continue operation. 
    ''' For example, the service increments this value as it completes each step 
    ''' of its initialization when it is starting up. The user interface program 
    ''' that invokes the operation on the service uses this value to track the progress 
    ''' of the service during a lengthy operation. 
    ''' This value is not valid and should be zero when the service does not have a start, 
    ''' stop, pause, or continue operation pending.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property CheckPoint As Int32
        Get
            Return ManagementObject("CheckPoint")
        End Get
    End Property

    ''' <summary>
    ''' Name of the first concrete class to appear in the inheritance chain used in the creation 
    ''' of an instance. When used with the other key properties of the class, this property allows 
    ''' all instances of this class and its subclasses to be uniquely identified.
    ''' Max Len : 256
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property CreationClassName As String
        Get
            Return ManagementObject("CreationClassName")
        End Get
    End Property

    ''' <summary>
    ''' Description of the object.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Description As String
        Get
            Return ManagementObject("Description")
        End Get
    End Property

    ''' <summary>
    ''' Service can create or communicate with windows on the desktop.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property DesktopInteract As Boolean
        Get
            Return ManagementObject("DesktopInteract")
        End Get
    End Property

    ''' <summary>
    ''' Display name of the service. This string has a maximum length of 256 characters.
    ''' The name is case-preserved in the Service Control Manager. However, DisplayName 
    ''' comparisons are always case-insensitive.
    ''' Constraint: Accepts the same value as the Name property.
    ''' Example: "Atdisk"
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property DisplayName As String
        Get
            Return ManagementObject("DisplayName")
        End Get
    End Property

    ''' <summary>
    ''' Severity of the error if this service fails to start during startup.
    ''' The value indicates the action taken by the startup program if failure occurs. 
    ''' All errors are logged by the computer system.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ErrorControl As ErrorControls
        Get
            Return [Enum].Parse(GetType(ErrorControls), ManagementObject("ErrorControl"))
        End Get
    End Property

    Public Enum ErrorControls
        ''' <summary>
        ''' User is not notified.
        ''' </summary>
        ''' <remarks></remarks>
        Ignore
        ''' <summary>
        ''' User is notified.
        ''' </summary>
        ''' <remarks></remarks>
        Normal
        ''' <summary>
        ''' System is restarted with the last-known-good configuration.
        ''' </summary>
        ''' <remarks></remarks>
        Severe
        ''' <summary>
        ''' System attempts to restart with a good configuration.
        ''' </summary>
        ''' <remarks></remarks>
        Critical
        ''' <summary>
        ''' Severity of the error is unknown.
        ''' </summary>
        ''' <remarks></remarks>
        Unknown
    End Enum

    ''' <summary>
    ''' Windows error code that defines errors encountered in starting or stopping 
    ''' the service. 
    ''' This property is set to ERROR_SERVICE_SPECIFIC_ERROR (1066) when the error 
    ''' is unique to the service represented by this class, and information about 
    ''' the error is available in the ServiceSpecificExitCode property. 
    ''' The service sets this value to NO_ERROR when running, and again upon normal termination.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ExitCode As Int32
        Get
            Return ManagementObject("ExitCode")
        End Get
    End Property

    ''' <summary>
    ''' Date object is installed. This property does not require a value to indicate that the object is installed.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property InstallDate As DateTime
        Get
            Return ManagementObject("InstallDate")
        End Get
    End Property

    ''' <summary>
    ''' Unique identifier of the service that provides an indication of the functionality that is managed.
    ''' This functionality is described in the Description property of the object.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Name As String
        Get
            Return ManagementObject("Name")
        End Get
    End Property

    ''' <summary>
    ''' Fully qualified path to the service binary file that implements the service.
    ''' Example: "\SystemRoot\System32\drivers\afd.sys"
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property PathName As String
        Get
            Return ManagementObject("PathName")
        End Get
    End Property

    ''' <summary>
    ''' Process identifier of the service.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ProcessId As Int32
        Get
            Return ManagementObject("ProcessId")
        End Get
    End Property

    ''' <summary>
    ''' Service-specific error code for errors that occur while the service is either starting or stopping. 
    ''' The exit codes are defined by the service represented by this class. 
    ''' This value is only set when the ExitCode property value is ERROR_SERVICE_SPECIFIC_ERROR (1066).
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ServiceSpecificExitCode As Int32
        Get
            Return ManagementObject("ServiceSpecificExitCode")
        End Get
    End Property

    ''' <summary>
    ''' Type of service provided to calling processes.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ServiceType As ServiceTypes
        Get
            Dim value As String = ManagementObject("ServiceType")
            Return [Enum].Parse(GetType(ServiceTypes), value.Replace(" ", ""))
        End Get
    End Property

    Public Enum ServiceTypes
        <StringValue("Kernel Driver")>
        KernelDriver
        <StringValue("File System Driver")>
        FileSystemDriver
        <StringValue("Adapter")>
        Adapter
        <StringValue("Recognizer Driver")>
        RecognizerDriver
        <StringValue("Own Process")>
        OwnProcess
        <StringValue("Share Process")>
        ShareProcess
        <StringValue("InteractiveProcess")>
        InteractiveProcess
    End Enum

    ''' <summary>
    ''' Service has been started.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Started As Boolean
        Get
            Return ManagementObject("Started")
        End Get
    End Property

    ''' <summary>
    ''' Start mode of the Windows base service.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property StartMode As StartModes
        Get
            Dim value As String = ManagementObject("StartMode")
            Return [Enum].Parse(GetType(StartModes), value.Replace(" ", ""))
        End Get
    End Property

    Public Enum StartModes
        ''' <summary>
        ''' Device driver started by the operating system loader (valid only for driver services).
        ''' </summary>
        ''' <remarks></remarks>
        Boot
        ''' <summary>
        ''' Device driver started by the operating system initialization process.
        ''' This value is valid only for driver services.
        ''' </summary>
        ''' <remarks></remarks>
        System
        ''' <summary>
        ''' Service to be started automatically by the service control manager during system startup.
        ''' </summary>
        ''' <remarks></remarks>
        Auto
        ''' <summary>
        ''' Service to be started by the Service Control Manager when a process calls the StartService method.
        ''' </summary>
        ''' <remarks></remarks>
        Manual
        ''' <summary>
        ''' Service that cannot be started.
        ''' </summary>
        ''' <remarks></remarks>
        Disabled
        ''' <summary>
        ''' Can happen if an external tools 'disables' a service.
        ''' </summary>
        ''' <remarks></remarks>
        Unknown
    End Enum

    ''' <summary>
    ''' Account name under which a service runs. Depending on the service type, the account name may be in the form 
    ''' of DomainName\Username. 
    ''' The service process is logged by using one of these two forms when it runs. 
    ''' If the account belongs to the built-in domain, then .\Username can be specified. 
    ''' For kernel or system-level drivers, StartName contains the driver object name (that is, \FileSystem\Rdr or \Driver\Xns)
    '''  which the I/O system uses to load the device driver. 
    ''' Additionally, if NULL is specified, the driver runs with a default object name created by the I/O system based 
    ''' on the service name.
    ''' Example: "DWDOM\Admin"
    ''' Windows XP:  You can use UPN format (Username@DomainName) to specify the StartName.
    ''' Windows 2000:  To change from a specified user to the LocalSystem account, use .\LocalSystem.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property StartName As String
        Get
            Return ManagementObject("StartName")
        End Get
    End Property

    ''' <summary>
    ''' Current state of the base service.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property State As States
        Get
            Dim value As String = ManagementObject("State")
            Return [Enum].Parse(GetType(States), value.Replace(" ", ""))
        End Get
    End Property

    Public Enum States
        <StringValue("Stopped")>
        Stopped
        <StringValue("Start Pending")>
        StartPending
        <StringValue("Stop Pending")>
        StopPending
        <StringValue("Running")>
        Running
        <StringValue("Continue Pending")>
        ContinuePending
        <StringValue("Pause Pending")>
        PausePending
        <StringValue("Paused")>
        Paused
        <StringValue("Unknown")>
        Unknown
    End Enum

    ''' <summary>
    ''' Current status of the object. 
    ''' Various operational and nonoperational statuses can be defined. 
    ''' Operational statuses include: 
    ''' "OK", "Degraded", and "Pred Fail" (an element, such as a SMART-enabled hard disk drive, may be functioning properly 
    ''' but predicting a failure in the near future). 
    ''' Nonoperational statuses include: "Error", "Starting", "Stopping", and "Service". 
    ''' The latter, "Service", could apply during mirror-resilvering of a disk, reload of a user permissions list, 
    ''' or other administrative work. Not all such work is online, yet the managed element is neither "OK" nor in 
    ''' one of the other states.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Status As Statuses
        Get
            Dim value As String = ManagementObject("Status")
            Return [Enum].Parse(GetType(Statuses), value.Replace(" ", ""))
        End Get
    End Property

    Public Enum Statuses
        OK
        [Error]
        Degraded
        Unknown
        <StringValue("Pred Fail")>
        PredFail
        Starting
        Stopping
        Service
    End Enum

    ''' <summary>
    ''' Type name of the system that hosts this service.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property SystemCreationClassName As String
        Get
            Return ManagementObject("SystemCreationClassName")
        End Get
    End Property

    ''' <summary>
    ''' Name of the system that hosts this service.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property SystemName As String
        Get
            Return ManagementObject("SystemName")
        End Get
    End Property

    ''' <summary>
    ''' Unique tag value for this service in the group. A value of 0 (zero) indicates that the service does not have a tag.
    ''' A tag can be used to order service startup within a load order group by specifying a tag order vector in the registry 
    ''' located at:
    ''' HKEY_LOCAL_MACHINE\System\CurrentControlSet\Control\    GroupOrderList
    ''' Tags are only evaluated for Kernel Driver and File System Driver start type services that have Boot or System start modes.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property TagId As Int32
        Get
            Return ManagementObject("TagId")
        End Get
    End Property

    ''' <summary>
    ''' Estimated time required, in milliseconds, for a pending start, stop, pause, or continue operation. 
    ''' After the specified time has elapsed, the service makes its next call to the SetServiceStatus method with either an 
    ''' incremented CheckPoint value or a change in CurrentState. 
    ''' If the amount of time specified by WaitHint passes, and CheckPoint has not been incremented, or CurrentState has not 
    ''' changed, the service control manager or service control program assumes that an error has occurred.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property WaitHint As Int32
        Get
            Return ManagementObject("WaitHint")
        End Get
    End Property

    ''' <summary>
    ''' Modifies the start mode of a service
    ''' </summary>
    ''' <param name="value"></param>
    ''' <remarks></remarks>
    Public Sub ChangeStartMode(ByVal value As String)
        If value = "Auto" Then value = "Automatic"
        Dim mp As ManagementBaseObject = ManagementClass.GetMethodParameters("ChangeStartMode")
        Dim result As Object = ManagementObject.InvokeMethod("ChangeStartMode", New Object() {value})
        MayThrowException(result, value)
    End Sub

    Public Sub ChangeStartMode(ByVal mode As StartModes)
        ChangeStartMode([Enum].GetName(GetType(StartModes), mode))
    End Sub

    ''' <summary>
    ''' Attempts to place a service in the paused state.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub PauseService()
        ManagementObject("State") = States.PausePending.ToString()
        RaiseEventOperationPending()

        Dim result As Integer = ManagementObject.InvokeMethod("PauseService", New Object() {})
        MayThrowException(result, "Paused")
    End Sub

    Protected Sub MayThrowException(ByVal error_number As String, ByVal status As String)
        Dim msg As String = ""
        Select Case error_number
            Case 0
                Return
            Case 1
                msg = "Not Supported"
            Case 2
                msg = "Access Denied"
            Case 3
                msg = "Dependent Services Running"
            Case 4
                msg = "Invalid Service Control"
            Case 5
                msg = "Service Cannot Accept Control"
            Case 6
                msg = "Service Not Active"
            Case 7
                msg = "Service Request Timeout"
            Case 8
                msg = "Unknown Failure"
            Case 9
                msg = "Path Not Found"
            Case 10
                msg = "Service Already Running"
            Case 11
                msg = "Service Database Locked"
            Case 12
                msg = "Service Dependency Deleted"
            Case 13
                msg = "Service Dependency Failure"
            Case 14
                msg = "Service Disabled"
            Case 15
                msg = "Service Logon Failure"
            Case 16
                msg = "Service Marked For Deletion"
            Case 17
                msg = "Service No Thread"
            Case 18
                msg = "Status Circular Dependency"
            Case 19
                msg = "Status Duplicate Name"
            Case 20
                msg = "Status Invalid Name"
            Case 21
                msg = "Status Invalid Parameter"
            Case 22
                msg = "Status Invalid Service Account"
            Case 23
                msg = "Status Service Exists"
            Case 24
                msg = "Service Already " + status
        End Select

        RaiseEventExceptionRaised(New Exception(msg))
    End Sub

    ''' <summary>
    ''' Attempts to place a service in the resumed state.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ResumeService()
        ManagementObject("State") = States.StartPending.ToString()
        RaiseEventOperationPending()

        Dim result As Integer = ManagementObject.InvokeMethod("ResumeService", New Object() {})
        MayThrowException(result, "Resumed")
    End Sub

    Public Sub StartService()
        ManagementObject("State") = States.StartPending.ToString()
        RaiseEventOperationPending()

        Dim result As Object = ManagementObject.InvokeMethod("StartService", New Object() {})
        MayThrowException(result, "Started")
    End Sub

    Public Sub StopService()
        ManagementObject("State") = States.StopPending.ToString()
        RaiseEventOperationPending()

        Dim result As Object = ManagementObject.InvokeMethod("StopService", New Object() {})
        MayThrowException(result, "Stopped")
    End Sub

End Class
