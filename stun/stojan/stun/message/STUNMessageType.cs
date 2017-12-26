/*
 * Copyright (c) 2016 Stojan Dimitrovski
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy of
 * this software and associated documentation files (the "Software"), to deal in
 * the Software without restriction, including without limitation the rights to
 * use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies
 * of the Software, and to permit persons to whom the Software is furnished to do
 * so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

namespace STUN.me.stojan.stun.message {
	/// <summary>
	/// Defines the STUN message types.
	/// </summary>
	public enum STUNMessageType : int {
		/// <summary>
		/// STUN class "request"
		/// </summary>
		GROUP_REQUEST = 0b00,

		/// <summary>
		/// STUN class "indication"
		/// </summary>
		GROUP_INDICATION = 0b01,

		/// <summary>
		/// STUN class "response success"
		/// </summary>
		GROUP_RESPONSE_SUCCESS = 0b10,

		/// <summary>
		/// STUN class "response error"
		/// </summary>
		GROUP_RESPONSE_ERROR = 0b11,

		/// <summary>
		/// STUN method "binding"
		/// </summary>
		METHOD_BINDING = 1,
	}
}
