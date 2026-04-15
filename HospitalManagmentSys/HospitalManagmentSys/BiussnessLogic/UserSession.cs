using HospitalManagmentSys.Data.Models;

namespace HospitalManagmentSys.BiussnessLogic
{
    /// <summary>
    /// Singleton service to manage the current user session across the application.
    /// </summary>
    public static class UserSession
    {
        private static User? _currentUser;

        /// <summary>
        /// Gets the currently logged-in user.
        /// </summary>
        public static User? CurrentUser => _currentUser;

        /// <summary>
        /// Gets whether a user is currently logged in.
        /// </summary>
        public static bool IsLoggedIn => _currentUser != null;

        /// <summary>
        /// Gets the current user's role.
        /// </summary>
        public static UserRole? CurrentRole => _currentUser?.Role;

        /// <summary>
        /// Sets the current logged-in user.
        /// </summary>
        public static void SetUser(User user)
        {
            _currentUser = user;
        }

        /// <summary>
        /// Clears the current user session (logout).
        /// </summary>
        public static void Clear()
        {
            _currentUser = null;
        }

        /// <summary>
        /// Gets the doctor ID if the current user is a doctor.
        /// </summary>
        public static int? GetDoctorId()
        {
            if (_currentUser?.Role == UserRole.Doctor && _currentUser.Doctor != null)
            {
                return _currentUser.Doctor.Id;
            }
            return null;
        }
    }
}
