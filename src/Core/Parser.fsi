// Signature file for parser generated by fsyacc
module Lw.Core.Parser
type token = 
  | EOF
  | TYPE
  | EQ
  | STAR
  | ARROW
  | VAL
  | OVER
  | BRAGT
  | LTKET
  | BRALT
  | GTKET
  | HASH
  | DO
  | INJECT
  | EJECT
  | IMPLIES
  | DATATYPE
  | DATA
  | FORALL
  | LET
  | REC
  | IN
  | IF
  | THEN
  | ELSE
  | FUN
  | MATCH
  | WHEN
  | WITH
  | FUNCTION
  | TRUE
  | FALSE
  | AS
  | OF
  | NAMESPACE
  | OPEN
  | WHERE
  | OVERLOAD
  | DOUBLEAMP
  | DOUBLEPIPE
  | UNDERSCORE
  | BACKSLASH
  | KIND
  | QUESTION
  | BRA
  | KET
  | CURBRA
  | CURKET
  | SQBRA
  | SQKET
  | PLUS
  | MINUS
  | SLASH
  | PLUSDOT
  | MINUSDOT
  | MOD
  | NEQ
  | LT
  | GT
  | LEQ
  | GEQ
  | AND
  | NOT
  | PIPE
  | AMP
  | BANG
  | COLONGT
  | COLON
  | COLON2
  | SEMICOLON
  | SEMICOLON2
  | DOT
  | COMMA
  | ASSIGN
  | STRING of (System.String)
  | UID of (System.String)
  | LID of (System.String)
  | INFIX of (System.String)
  | TICK_ID of (System.String)
  | BACKTICK_ID of (System.String)
  | AT_ID of (System.String)
  | CHAR of (System.Char)
  | FLOAT of (System.Double)
  | INT32 of (System.Int32)
  | AT_INT32 of (System.Int32)
type tokenId = 
    | TOKEN_EOF
    | TOKEN_TYPE
    | TOKEN_EQ
    | TOKEN_STAR
    | TOKEN_ARROW
    | TOKEN_VAL
    | TOKEN_OVER
    | TOKEN_BRAGT
    | TOKEN_LTKET
    | TOKEN_BRALT
    | TOKEN_GTKET
    | TOKEN_HASH
    | TOKEN_DO
    | TOKEN_INJECT
    | TOKEN_EJECT
    | TOKEN_IMPLIES
    | TOKEN_DATATYPE
    | TOKEN_DATA
    | TOKEN_FORALL
    | TOKEN_LET
    | TOKEN_REC
    | TOKEN_IN
    | TOKEN_IF
    | TOKEN_THEN
    | TOKEN_ELSE
    | TOKEN_FUN
    | TOKEN_MATCH
    | TOKEN_WHEN
    | TOKEN_WITH
    | TOKEN_FUNCTION
    | TOKEN_TRUE
    | TOKEN_FALSE
    | TOKEN_AS
    | TOKEN_OF
    | TOKEN_NAMESPACE
    | TOKEN_OPEN
    | TOKEN_WHERE
    | TOKEN_OVERLOAD
    | TOKEN_DOUBLEAMP
    | TOKEN_DOUBLEPIPE
    | TOKEN_UNDERSCORE
    | TOKEN_BACKSLASH
    | TOKEN_KIND
    | TOKEN_QUESTION
    | TOKEN_BRA
    | TOKEN_KET
    | TOKEN_CURBRA
    | TOKEN_CURKET
    | TOKEN_SQBRA
    | TOKEN_SQKET
    | TOKEN_PLUS
    | TOKEN_MINUS
    | TOKEN_SLASH
    | TOKEN_PLUSDOT
    | TOKEN_MINUSDOT
    | TOKEN_MOD
    | TOKEN_NEQ
    | TOKEN_LT
    | TOKEN_GT
    | TOKEN_LEQ
    | TOKEN_GEQ
    | TOKEN_AND
    | TOKEN_NOT
    | TOKEN_PIPE
    | TOKEN_AMP
    | TOKEN_BANG
    | TOKEN_COLONGT
    | TOKEN_COLON
    | TOKEN_COLON2
    | TOKEN_SEMICOLON
    | TOKEN_SEMICOLON2
    | TOKEN_DOT
    | TOKEN_COMMA
    | TOKEN_ASSIGN
    | TOKEN_STRING
    | TOKEN_UID
    | TOKEN_LID
    | TOKEN_INFIX
    | TOKEN_TICK_ID
    | TOKEN_BACKTICK_ID
    | TOKEN_AT_ID
    | TOKEN_CHAR
    | TOKEN_FLOAT
    | TOKEN_INT32
    | TOKEN_AT_INT32
    | TOKEN_end_of_input
    | TOKEN_error
type nonTerminalId = 
    | NONTERM__startinteractive_line
    | NONTERM__startexpr
    | NONTERM__startprogram
    | NONTERM__starttop_decl
    | NONTERM__startty_expr
    | NONTERM_interactive_line
    | NONTERM_program
    | NONTERM_program_1
    | NONTERM_program_2
    | NONTERM_program_3
    | NONTERM_namespacee
    | NONTERM_top_decls
    | NONTERM_top_decl
    | NONTERM_let_quals
    | NONTERM_nested_decl
    | NONTERM_nested_decl_
    | NONTERM_datatype
    | NONTERM_datatype_bindings
    | NONTERM_datatype_bindings_
    | NONTERM_datatype_binding
    | NONTERM_let_or_letrec_decl
    | NONTERM_let_or_letrec_decl_
    | NONTERM_let_and_bindings
    | NONTERM_letrec_and_bindings
    | NONTERM_over_and_bindings
    | NONTERM_ty_expr_and_bindings
    | NONTERM_ty_expr_rec_and_bindings
    | NONTERM_kind_and_bindings
    | NONTERM_let_qbinding
    | NONTERM_letrec_qbinding
    | NONTERM_let_binding
    | NONTERM_letrec_binding
    | NONTERM_over_binding
    | NONTERM_ty_expr_binding
    | NONTERM_ty_expr_rec_binding
    | NONTERM_kind_binding
    | NONTERM_kind_params
    | NONTERM_fun_patt_params
    | NONTERM_fun_param_case
    | NONTERM_fun_param_cases
    | NONTERM_fun_param_cases_
    | NONTERM_ty_fun_patt_params
    | NONTERM_ty_fun_param_case
    | NONTERM_ty_fun_param_cases
    | NONTERM_ty_fun_param_cases_
    | NONTERM_id
    | NONTERM_typed_param
    | NONTERM_kinded_param
    | NONTERM_ty_forall_param
    | NONTERM_ty_forall_params
    | NONTERM_kind_annotation
    | NONTERM_kind
    | NONTERM_kind_arrow_atom
    | NONTERM_kind_tuple
    | NONTERM_kind_tuple_atom
    | NONTERM_kind_arg
    | NONTERM_kind_args
    | NONTERM_ty_expr_annotation
    | NONTERM_ty_expr
    | NONTERM_ty_expr_tuple_atom
    | NONTERM_ty_expr_htuple_atom
    | NONTERM_ty_expr_app_atom
    | NONTERM_ty_expr_
    | NONTERM_ty_expr_htuple
    | NONTERM_ty_expr_htuple_atom_
    | NONTERM_ty_expr_tuple
    | NONTERM_ty_expr_tuple_atom_
    | NONTERM_ty_expr_app_atom_
    | NONTERM_ty_expr_record
    | NONTERM_let_ty_decls
    | NONTERM_let_ty_decl
    | NONTERM_let_ty_decl_
    | NONTERM_ty_patt
    | NONTERM_ty_patt_arrow_atom
    | NONTERM_ty_patt_htuple_atom
    | NONTERM_ty_patt_tuple_atom
    | NONTERM_ty_patt_app_atom
    | NONTERM_ty_patt_
    | NONTERM_ty_patt_arrow_atom_
    | NONTERM_ty_patt_htuple
    | NONTERM_ty_patt_htuple_atom_
    | NONTERM_ty_patt_tuple_atom_
    | NONTERM_ty_patt_tuple
    | NONTERM_ty_patt_app_atom_
    | NONTERM_ty_cases
    | NONTERM_ty_cases_
    | NONTERM_ty_case
    | NONTERM_ty_cases2_
    | NONTERM_ty_case2
    | NONTERM_expr
    | NONTERM_expr_stmt_atom
    | NONTERM_expr_app_atom
    | NONTERM_expr_tuple_atom
    | NONTERM_expr_
    | NONTERM_expr_stmts
    | NONTERM_expr_stmt_atom_
    | NONTERM_expr_tuple
    | NONTERM_expr_tuple_atom_
    | NONTERM_expr_app_atom_
    | NONTERM_let_decls
    | NONTERM_inner_decl
    | NONTERM_cases
    | NONTERM_cases_
    | NONTERM_case
    | NONTERM_cases2_
    | NONTERM_case2
    | NONTERM_symbol
    | NONTERM_lit
    | NONTERM_expr_list
    | NONTERM_expr_record_atom
    | NONTERM_record
    | NONTERM_patt
    | NONTERM_patt_arrow_atom
    | NONTERM_patt_tuple_atom
    | NONTERM_patt_app_atom
    | NONTERM_patt_
    | NONTERM_patt_arrow_atom_
    | NONTERM_patt_tuple_atom_
    | NONTERM_patt_tuple
    | NONTERM_patt_app_atom_
    | NONTERM_patt_record_item
    | NONTERM_patt_record
    | NONTERM_patt_list
/// This function maps tokens to integer indexes
val tagOfToken: token -> int

/// This function maps integer indexes to symbolic token ids
val tokenTagToTokenId: int -> tokenId

/// This function maps production indexes returned in syntax errors to strings representing the non terminal that would be produced by that production
val prodIdxToNonTerminal: int -> nonTerminalId

/// This function gets the name of a token as a string
val token_to_string: token -> string
val interactive_line : (Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> token) -> Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> ( Lw.Core.Absyn.interactive_line ) 
val expr : (Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> token) -> Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> ( Lw.Core.Absyn.expr ) 
val program : (Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> token) -> Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> ( Lw.Core.Absyn.program ) 
val top_decl : (Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> token) -> Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> ( Lw.Core.Absyn.decl ) 
val ty_expr : (Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> token) -> Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> ( Lw.Core.Absyn.ty_expr ) 
