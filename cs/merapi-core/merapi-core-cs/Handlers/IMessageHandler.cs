﻿/////////////////////////////////////////////////////////////////////////////////////
//
//  This program is free software; you can redistribute it and/or modify 
//  it under the terms of the GNU Lesser General Public License as published 
//  by the Free Software Foundation; either version 3 of the License, or (at 
//  your option) any later version.
//
//  This program is distributed in the hope that it will be useful, but 
//  WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY 
//  or FITNESS FOR A PARTICULAR PURPOSE. See the GNU Lesser General Public 
//  License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License 
//  along with this program; if not, see <http://www.gnu.org/copyleft/lesser.html>.
//
/////////////////////////////////////////////////////////////////////////////////////


using merapi.messages;

namespace Merapi.Handlers
{
    /**
     *  The <code>IEventHandler</code> interface defines the methods for receiving a 
     *  <code>MerapiEvent</code> from the Bridge.
     * 
     *  @see Merapi.Bridge
     */
    public interface IMessageHandler
    {
        //--------------------------------------------------------------------------
        //
        //  Methods
        //
        //--------------------------------------------------------------------------

        /**
         *  Handles an <code>IMessage</code> dispatched from the Bridge.
         */
        void HandleMessage( IMessage message );

        /**
         *  Removes all types being listened for by this IMessageHandler
         */
        void UnregisterAllTypes();
    }
}
