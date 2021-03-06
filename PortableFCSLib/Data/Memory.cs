// Copyright (C) 2011 Oliver Sturm <oliver@oliversturm.com>
//
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 3 of the License, or (at your option) any later version.
//
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
// Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, see <http://www.gnu.org/licenses/>.


using System.Collections.Generic;

namespace PortableFCSLib.Data {
  public class Memory<P, R> : IMemory<P, R> {
    Dictionary<P, R> storage = new Dictionary<P, R>( );

    public bool HasResultFor(P val) {
      return storage.ContainsKey(val);
    }

    public R ResultFor(P val) {
      return storage[val];
    }

    public void Remember(P val, R result) {
      storage[val] = result;
    }
  }
}
