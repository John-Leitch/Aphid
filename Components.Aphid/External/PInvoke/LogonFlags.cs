namespace Components.PInvoke
{
    public enum LogonFlags
    {
        /// <summary>
        /// Log on, then load the user's profile in the HKEY_USERS registry key. The function
        /// returns after the profile has been loaded. Loading the profile can be time-consuming,
        /// so it is best to use this value only if you must access the information in the 
        /// HKEY_CURRENT_USER registry key. 
        /// NOTE: Windows Server 2003: The profile is unloaded after the new process has been
        /// terminated, regardless of whether it has created child processes.
        /// </summary>
        /// <remarks>See LOGON_WITH_PROFILE</remarks>
        WithProfile = 1,
        /// <summary>
        /// Log on, but use the specified credentials on the network only. The new process uses the
        /// same token as the caller, but the system creates a new logon session within LSA, and
        /// the process uses the specified credentials as the default credentials.
        /// This value can be used to create a process that uses a different set of credentials
        /// locally than it does remotely. This is useful in inter-domain scenarios where there is
        /// no trust relationship.
        /// The system does not validate the specified credentials. Therefore, the process can start,
        /// but it may not have access to network resources.
        /// </summary>
        /// <remarks>See LOGON_NETCREDENTIALS_ONLY</remarks>
        NetCredentialsOnly
    }
}
