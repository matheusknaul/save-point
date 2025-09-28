using Interfaces;
using Models.Enums;
using System.Transactions;

namespace Models.Entities
{
    /// <summary>
    /// This class represents the register that be save.
    /// You can save just class in this register.
    /// </summary>
    public class Register<T> where T : class
    {
        #region Properties

        /// <summary>
        /// Register Id
        /// </summary>
        public long Id { get;}

        #endregion

        #region Internal State

        #endregion

        /// <summary>
        /// Register Options
        /// </summary>
        private readonly ISaveOptions _options;

        /// <summary>
        /// Entity that be storage in save point.
        /// </summary>
        private readonly T _entity;

        /// <summary>
        /// Datetime that was created.
        /// </summary>
        private readonly DateTime _createdAt;

        /// <summary>
        /// Datetime of the last update.
        /// </summary>
        private readonly DateTime _updatedAt;

        /// <summary>
        /// Transaction Type
        /// </summary>
        private readonly TransactionType transactionType;

        /// <summary>
        /// Last readed at
        /// </summary>
        private readonly DateTime _lastReadedAt;

    }
}
