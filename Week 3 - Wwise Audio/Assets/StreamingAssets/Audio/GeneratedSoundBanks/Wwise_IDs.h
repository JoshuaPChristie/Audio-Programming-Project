/////////////////////////////////////////////////////////////////////////////////////////////////////
//
// Audiokinetic Wwise generated include file. Do not edit.
//
/////////////////////////////////////////////////////////////////////////////////////////////////////

#ifndef __WWISE_IDS_H__
#define __WWISE_IDS_H__

#include <AK/SoundEngine/Common/AkTypes.h>

namespace AK
{
    namespace EVENTS
    {
        static const AkUniqueID BARS = 1274655763U;
        static const AkUniqueID BIRDSONG = 3886820807U;
        static const AkUniqueID BUTTON = 977454165U;
        static const AkUniqueID COIN_PICKUP = 98870701U;
        static const AkUniqueID COIN_SPARKLE = 3959935949U;
        static const AkUniqueID COLUMN = 4252072479U;
        static const AkUniqueID DOOR = 1877847629U;
        static const AkUniqueID FOOTSTEPS = 2385628198U;
        static const AkUniqueID GUN_FIRE = 2517641552U;
        static const AkUniqueID GUN_PICKUP = 4088467408U;
        static const AkUniqueID JUMP = 3833651337U;
        static const AkUniqueID LANDING = 2548270042U;
        static const AkUniqueID MUSIC = 3991942870U;
        static const AkUniqueID WOODEN_DOOR = 193209502U;
    } // namespace EVENTS

    namespace STATES
    {
        namespace COINSCOLLECTED
        {
            static const AkUniqueID GROUP = 2284983946U;

            namespace STATE
            {
                static const AkUniqueID FIVE = 2611770117U;
                static const AkUniqueID FOUR = 2863728729U;
                static const AkUniqueID NONE = 748895195U;
                static const AkUniqueID ONE = 1064933119U;
                static const AkUniqueID THREE = 912956111U;
                static const AkUniqueID TWO = 678209053U;
                static const AkUniqueID ZERO = 766521211U;
            } // namespace STATE
        } // namespace COINSCOLLECTED

        namespace GAMESTATE
        {
            static const AkUniqueID GROUP = 4091656514U;

            namespace STATE
            {
                static const AkUniqueID DISCOVERY = 3663283413U;
                static const AkUniqueID NONE = 748895195U;
                static const AkUniqueID PUZZLE = 1780448749U;
                static const AkUniqueID VICTORY = 2716678721U;
            } // namespace STATE
        } // namespace GAMESTATE

    } // namespace STATES

    namespace BANKS
    {
        static const AkUniqueID INIT = 1355168291U;
        static const AkUniqueID MAIN = 3161908922U;
    } // namespace BANKS

    namespace BUSSES
    {
        static const AkUniqueID MASTER_AUDIO_BUS = 3803692087U;
    } // namespace BUSSES

    namespace AUX_BUSSES
    {
        static const AkUniqueID BIG_ROOM = 4202071913U;
        static const AkUniqueID CORRIDOR = 4063189299U;
        static const AkUniqueID MEDIUM_ROOM = 1834233174U;
        static const AkUniqueID SMALL_ROOM = 4103918620U;
    } // namespace AUX_BUSSES

    namespace AUDIO_DEVICES
    {
        static const AkUniqueID NO_OUTPUT = 2317455096U;
        static const AkUniqueID SYSTEM = 3859886410U;
    } // namespace AUDIO_DEVICES

}// namespace AK

#endif // __WWISE_IDS_H__
