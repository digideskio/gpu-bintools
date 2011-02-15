// Author:
//       Justin Holewinski <justin.holewinski@gmail.com>
// 
// Copyright (c) 2011 Justin Holewinski
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;

namespace GpuTools.AmdIl
{
  /// <summary>
  /// Token type enumeration.
  /// </summary>
  public enum TokenType
  {
    Comma,
    OpenParenthesis,
    CloseParenthesis,
    OpenBrace,
    CloseBrace,

    Literal,
    Constant,
    Identifier,
    ConstantBuffer,
    Register,
  }

  /// <summary>
  /// Definition of an AMDIL token for the parser.
  /// </summary>
  public struct Token
  {
    #region Fields

    /// <summary>
    /// Gets the token type.
    /// </summary>
    public TokenType Type { get; private set; }

    /// <summary>
    /// Gets the text of the token, if meaningfull.
    /// </summary>
    public string Text { get; private set; }

    /// <summary>
    /// Gets the mask string, if register, literal, etc.
    /// </summary>
    public string Mask { get; private set; }

    #endregion


    #region Constructors

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="type">The token type.</param>
    public Token(TokenType type)
      : this(type, null, null)
    {
    }

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="type">The token type.</param>
    /// <param name="text">The token text.</param.
    /// <param name="mask">The register mask.</param>
    public Token(TokenType type,
                 string    text,
                 string    mask)
    {
      Type = type;
      Text = text;
      Mask = mask;

      Console.WriteLine(type);
    }

    #endregion

  }
}

