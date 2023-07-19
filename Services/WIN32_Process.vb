Imports System.Collections.Generic
Imports System.Management

Public Class WIN32_Process
    Inherits WIN32_ManagedItem

    Public Sub New()
        MyBase.New(Nothing)
    End Sub

    Public Sub New(ByVal mo As ManagementObject)
        MyBase.New(mo)
    End Sub

    ''' <summary>
    ''' Short description of an object—a one-line string.
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
    ''' Command line used to start a specific process, if applicable. This property is new for Windows XP.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property CommandLine As String
        Get
            Return ManagementObject("CommandLine")
        End Get
    End Property

    ''' <summary>
    ''' Name of the first concrete class in the inheritance chain that is used to create an instance. 
    ''' You can use this property with other key properties of the class to uniquely identify all of the instances of the class and its subclasses. 
    ''' This property is inherited from CIM_System.
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
    ''' Date the process begins executing.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property CreationDate As DateTime
        Get
            Return ManagementObject("CreationDate")
        End Get
    End Property

    ''' <summary>
    ''' Creation class name of the scoping computer system.
    ''' Qualifiers: Key, MaxLen (256)
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property CSCreationClassName As String
        Get
            Return ManagementObject("CSCreationClassName")
        End Get
    End Property

    ''' <summary>
    ''' Name of the scoping computer system.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property CSName As String
        Get
            Return ManagementObject("CSName")
        End Get
    End Property

    ''' <summary>
    ''' Description of an object.
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
    ''' Path to the executable file of the process.
    ''' Qualifiers: Privileges (SeDebugPrivilege)
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ExecutablePath As String
        Get
            Return ManagementObject("ExecutablePath")
        End Get
    End Property

    ''' <summary>
    ''' This property is not implemented and does not get populated for any instance of this class. This property is always NULL.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private ReadOnly Property ExecutionState As Int16
        Get
            Return ManagementObject("ExecutionState")
        End Get
    End Property

    ''' <summary>
    ''' Process identifier.
    ''' Qualifiers: Key
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Handle As String
        Get
            Return ManagementObject("Handle")
        End Get
    End Property

    ''' <summary>
    ''' Total number of open handles owned by the process. 
    ''' HandleCount is the sum of the handles currently open by each thread in this process. 
    ''' A handle is used to examine or modify the system resources. 
    ''' Each handle has an entry in a table that is maintained internally. 
    ''' Entries contain the addresses of the resources and data to identify the resource type.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property HandleCount As Int32
        Get
            Return ManagementObject("HandleCount")
        End Get
    End Property

    ''' <summary>
    ''' Date an object is installed.
    ''' The object may be installed without a value being written to this property.
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
    ''' Time in kernel mode, in 100 nanosecond units. If this information is not available, use a value of 0 (zero).
    ''' For more information about using uint64 values in scripts, see <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/aa393262(v=vs.85).aspx">Scripting in WMI</a>.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property KernelModeTime As Int64
        Get
            Return ManagementObject("KernelModeTime")
        End Get
    End Property

    ''' <summary>
    ''' Maximum working set size of the process. 
    ''' The working set of a process is the set of memory pages visible to the process in physical RAM. 
    ''' These pages are resident, and available for an application to use without triggering a page fault.
    ''' Example: 1413120
    ''' Qualifiers: Privileges (SeDebugPrivilege) , Units (Kilobytes)
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property MaximumWorkingSetSize As Int32
        Get
            Return ManagementObject("MaximumWorkingSetSize")
        End Get
    End Property

    ''' <summary>
    ''' Minimum working set size of the process. 
    ''' The working set of a process is the set of memory pages visible to the process in physical RAM. 
    ''' These pages are resident and available for an application to use without triggering a page fault.
    ''' Example: 20480
    ''' Qualifiers: Privileges (SeDebugPrivilege) , Units (Kilobytes)
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property MinimumWorkingSetSize As Int32
        Get
            Return ManagementObject("MinimumWorkingSetSize")
        End Get
    End Property

    ''' <summary>
    ''' Label for an object. 
    ''' When inherited by a subclass, the property can be overridden to be a key property.
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
    ''' Creation class name of the scoping operating system.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property OSCreationClassName As String
        Get
            Return ManagementObject("OSCreationClassName")
        End Get
    End Property

    ''' <summary>
    ''' Name of the scoping operating system.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property OSName As String
        Get
            Return ManagementObject("OSName")
        End Get
    End Property

    ''' <summary>
    ''' Number of I/O operations performed that are not read or write operations.
    ''' For more information about using uint64 values in scripts, see Scripting in WMI.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property OtherOperationCount As Int64
        Get
            Return ManagementObject("OtherOperationCount")
        End Get
    End Property

    ''' <summary>
    ''' Amount of data transferred during operations that are not read or write operations.
    ''' For more information about using uint64 values in scripts, see Scripting in WMI.
    ''' Qualifiers: Units (Bytes)
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property OtherTransferCount As Int64
        Get
            Return ManagementObject("OtherTransferCount")
        End Get
    End Property

    ''' <summary>
    ''' Number of page faults that a process generates.
    ''' Example: 10
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property PageFaults As Int32
        Get
            Return ManagementObject("PageFaults")
        End Get
    End Property

    ''' <summary>
    ''' Amount of page file space that a process is using currently.
    ''' This value is consistent with the VMSize value in TaskMgr.exe.
    ''' Example: 102435
    ''' Qualifiers: Units (Kilobytes)
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property PageFileUsage As Int32
        Get
            Return ManagementObject("PageFileUsage")
        End Get
    End Property

    ''' <summary>
    ''' Unique identifier of the process that creates a process. 
    ''' Process identifier numbers are reused, so they only identify a process for the lifetime of that process. 
    ''' It is possible that the process identified by ParentProcessId is terminated, so ParentProcessId may not refer to a running process. 
    ''' It is also possible that ParentProcessId incorrectly refers to a process that reuses a process identifier. 
    ''' You can use the CreationDate property to determine whether the specified parent was created after the process represented by this Win32_Process instance was created.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ParentProcessId As Int32
        Get
            Return ManagementObject("ParentProcessId")
        End Get
    End Property

    ''' <summary>
    ''' Maximum amount of page file space used during the life of a process.
    ''' Example: 102367
    ''' Qualifiers: Units (Kilobytes)
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property PeakPageFileUsage As Int32
        Get
            Return ManagementObject("PeakPageFileUsage")
        End Get
    End Property

    ''' <summary>
    ''' Qualifiers: Units (Bytes)
    ''' Maximum virtual address space a process uses at any one time. 
    ''' Using virtual address space does not necessarily imply corresponding use of either disk or main memory pages. 
    ''' However, virtual space is finite, and by using too much the process might not be able to load libraries.
    ''' For more information about using uint64 values in scripts, see Scripting in WMI.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property PeakVirtualSize As Int64
        Get
            Return ManagementObject("PeakVirtualSize")
        End Get
    End Property

    ''' <summary>
    ''' Qualifiers: Units (Kilobytes)
    ''' Peak working set size of a process.
    ''' Example: 1413120
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property PeakWorkingSetSize As Int32
        Get
            Return ManagementObject("PeakWorkingSetSize")
        End Get
    End Property

    ''' <summary>
    ''' Scheduling priority of a process within an operating system. 
    ''' The higher the value, the higher priority a process receives.
    ''' Priority values can range from 0 (zero), which is the lowest priority to 31, which is highest priority.
    ''' Example: 7
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property Priority As Int32
        Get
            Return ManagementObject("Priority")
        End Get
    End Property

    ''' <summary>
    ''' Current number of pages allocated that are only accessible to the process represented by this Win32_Process instance.
    ''' For more information about using uint64 values in scripts, see Scripting in WMI.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property PrivatePageCount As Int64
        Get
            Return ManagementObject("PrivatePageCount")
        End Get
    End Property

    ''' <summary>
    ''' Global process identifier that is used to identify a process.
    ''' The value is valid from the time a process is created until it is terminated.
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
    ''' Quota amount of nonpaged pool usage for a process.
    ''' Example: 15
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property QuotaNonPagedPoolUsage As Int32
        Get
            Return ManagementObject("QuotaNonPagedPoolUsage")
        End Get
    End Property

    ''' <summary>
    ''' Quota amount of paged pool usage for a process.
    ''' Example: 22
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property QuotaPagedPoolUsage As Int32
        Get
            Return ManagementObject("QuotaPagedPoolUsage")
        End Get
    End Property

    ''' <summary>
    ''' Peak quota amount of nonpaged pool usage for a process.
    ''' Example: 31
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property QuotaPeakNonPagedPoolUsage As Int32
        Get
            Return ManagementObject("QuotaPeakNonPagedPoolUsage")
        End Get
    End Property

    ''' <summary>
    ''' Peak quota amount of paged pool usage for a process.
    ''' Example: 31
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property QuotaPeakPagedPoolUsage As Int32
        Get
            Return ManagementObject("QuotaPeakPagedPoolUsage")
        End Get
    End Property

    ''' <summary>
    ''' Number of read operations performed.
    ''' For more information about using uint64 values in scripts, see Scripting in WMI.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ReadOperationCount As Int64
        Get
            Return ManagementObject("ReadOperationCount")
        End Get
    End Property

    ''' <summary>
    ''' Qualifiers: Units (Bytes)
    ''' Amount of data read.
    ''' For more information about using uint64 values in scripts, see Scripting in WMI.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ReadTransferCount As Int64
        Get
            Return ManagementObject("ReadTransferCount")
        End Get
    End Property

    ''' <summary>
    ''' Unique identifier that an operating system generates when a session is created.
    ''' A session spans a period of time from logon until logoff from a specific system.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property SessionId As Int32
        Get
            Return ManagementObject("SessionId")
        End Get
    End Property

    ''' <summary>
    ''' This property is not implemented and does not get populated for any instance of this class. It is always NULL.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private ReadOnly Property Status As String
        Get
            Return ManagementObject("Status")
        End Get
    End Property

    ''' <summary>
    ''' Process was stopped or terminated.
    ''' To get the termination time, a handle to the process must be held open. 
    ''' Otherwise, this property returns NULL.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property TerminationDate As DateTime
        Get
            Return ManagementObject("TerminationDate")
        End Get
    End Property

    ''' <summary>
    ''' Number of active threads in a process. 
    ''' An instruction is the basic unit of execution in a processor, and a thread is the object that executes an instruction. 
    ''' Each running process has at least one thread.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>
    ''' Windows Me/98/95:  This property is not available.
    ''' </remarks>
    Public ReadOnly Property ThreadCount As Int32
        Get
            Return ManagementObject("ThreadCount")
        End Get
    End Property

    ''' <summary>
    ''' Time in user mode, in 100 nanosecond units. 
    ''' If this information is not available, use a value of 0 (zero).
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>For more information about using uint64 values in scripts, see Scripting in WMI.</remarks>
    Public ReadOnly Property UserModeTime As Int64
        Get
            Return ManagementObject("UserModeTime")
        End Get
    End Property

    ''' <summary>
    ''' Qualifiers: Units (Bytes)
    ''' Current size of the virtual address space that a process is using, not the physical or virtual memory actually used by the process. 
    ''' Using virtual address space does not necessarily imply corresponding use of either disk or main memory pages. 
    ''' Virtual space is finite, and by using too much, the process might not be able to load libraries. 
    ''' This value is consistent with what you see in Perfmon.exe.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>For more information about using uint64 values in scripts, see Scripting in WMI.</remarks>
    Public ReadOnly Property VirtualSize As Int64
        Get
            Return ManagementObject("VirtualSize")
        End Get
    End Property

    ''' <summary>
    ''' Version of Windows in which the process is running.
    ''' Example: 4.0
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property WindowsVersion As String
        Get
            Return ManagementObject("WindowsVersion")
        End Get
    End Property

    ''' <summary>
    ''' Amount of memory in bytes that a process needs to execute efficiently—for an operating system that uses page-based memory management. 
    ''' If the system does not have enough memory (less than the working set size), thrashing occurs. 
    ''' If the size of the working set is not known, use NULL or 0 (zero). 
    ''' If working set data is provided, you can monitor the information to understand the changing memory requirements of a process.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>For more information about using uint64 values in scripts, see Scripting in WMI.</remarks>
    Public ReadOnly Property WorkingSetSize As Int64
        Get
            Return ManagementObject("WorkingSetSize")
        End Get
    End Property

    ''' <summary>
    ''' Number of write operations performed.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>For more information about using uint64 values in scripts, see Scripting in WMI.</remarks>
    Public ReadOnly Property WriteOperationCount As Int64
        Get
            Return ManagementObject("WriteOperationCount")
        End Get
    End Property

    ''' <summary>
    ''' Qualifiers: Units (Bytes)
    ''' Amount of data written.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks>For more information about using uint64 values in scripts, see Scripting in WMI.</remarks>
    Public ReadOnly Property WriteTransferCount As Int64
        Get
            Return ManagementObject("WriteTransferCount")
        End Get
    End Property

    Public Sub Terminate(ByVal reason As Int32)

    End Sub

    Public Sub SetPriority()
        'Dim objLoc As Object = CreateObject("WbemScripting.SWbemLocator")
        'objLoc.Security_.privileges.addasstring("sedebugprivilege", True)
    End Sub

    Private Sub MayThrowException(ByVal code As Integer)
        Dim msg As String = ""
        Select Case code
            Case 0
                '"Successful Completion"
                Exit Sub
            Case 2
                msg = "Access Denied"
            Case 3
                msg = "Insufficient Privilege"
            Case 8
                msg = "Unknown Failure"
            Case 9
                msg = "Path Not Found"
            Case 21
                msg = "Invalid Parameter"
        End Select
        RaiseEventExceptionRaised(New Exception(msg))
    End Sub

End Class
