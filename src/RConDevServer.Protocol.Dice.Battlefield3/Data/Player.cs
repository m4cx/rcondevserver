using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RConDevServer.Protocol.Dice.Battlefield3.Data
{
    using System.Runtime.Serialization;

    /// <summary>
    /// represents a player with his properties
    /// </summary>
    [DataContract]
    public class Player
    {
        #region Public Properties

        [Required]
        [StringLength(50, MinimumLength = 1)]
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string EaGuid { get; set; }

        [DataMember]
        public int TeamId { get; set; }

        [DataMember]
        public int SquadId { get; set; }

        [DataMember]
        public int Kills { get; set; }

        [DataMember]
        public int Deaths { get; set; }

        [DataMember]
        public int Score { get; set; }

        #endregion

        #region Constructor

        public Player()
        {
            this.EaGuid = "EA_" + Guid.NewGuid().ToString().Replace("-", string.Empty).ToUpper();
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Converts the player information to words
        /// </summary>
        /// <param name="showGuid">Flag to turn off showing the player's EA GUID</param>
        /// <returns></returns>
        public IEnumerable<string> ToWords(bool showGuid = true)
        {
            var words = new List<string>
                            {
                                Name,
                                (showGuid) ? EaGuid : string.Empty,
                                Convert.ToString(TeamId),
                                Convert.ToString(SquadId),
                                Convert.ToString(Kills),
                                Convert.ToString(Deaths),
                                Convert.ToString(Score)
                            };
            return words;
        }

        public IList<ValidationResult> Validate()
        {
            var context = new ValidationContext(this, null, null);
            var validationResults = new List<ValidationResult>();
            Validator.TryValidateObject(this, context, validationResults);
            return validationResults;
        } 

        #endregion
    }
}