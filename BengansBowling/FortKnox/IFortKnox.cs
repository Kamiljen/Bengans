using System;
using System.Collections.Generic;
using System.Text;

namespace BengansBowling.FortKnox
{
    public interface IFortKnox
    {
        bool BillMemberFee(int userId);
        bool BillTournamentFee(int tournamentId, int userId);
        bool MemberFeePayed(int memberId);
        bool TournamentFeePayed(int tournamentId, int memberId);
    }
}
