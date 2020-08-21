using System;
using System.Collections.Generic;
using System.Text;

namespace GitChallenge.Domain.RepositoryLanguages.RepositorySpecification
{
    public class RepositorySearchCriteriaSpecification
    {
        public RepositorySearchCriteriaSpecification(int take, SortByField sortByField, SortByDirection sortByDirection,  Language language)
        {
            Take = take;

            SortBy = sortByField;

            SortByDirection = sortByDirection;

            Language = language;
        }

        public RepositorySearchCriteriaSpecification(int take, SortByField sortByField, SortByDirection sortByDirection, ICollection<Language> languages)
        {
            Take = take;

            SortBy = sortByField;

            SortByDirection = sortByDirection;

            Languages = (IReadOnlyCollection<Language>) languages;
        }

        public SortByField SortBy { get; }

        public SortByDirection SortByDirection { get; }

        public IReadOnlyCollection<Language> Languages { get; }

        public Language? Language { get; }

        public int Take { get; }
    }

    public enum SortByField
    {
        Stars,
        Forks,
        Updated
    }

    public enum SortByDirection
    {
        Ascending,
        Descending
    }

    public enum Language
    {
        Abap,
        ActionScript,
        Ada,
        Apex,
        AppleScript,
        Arc,
        Arduino,
        ApacheConf,
        Asp,
        Assembly,
        Augeas,
        AutoHotKey,
        Awk,
        Batchfile,
        Befunge,
        BlitzMax,
        Boo,
        Bro,
        C,
        C2hsHaskell,
        Ceylon,
        Chuck,
        Clips,
        Clojure,
        Cobol,
        Cmake,
        CObjDump,
        CoffeeScript,
        ColdFusion,
        CommonLisp,
        Coq,
        CPlusPlus,
        CSharp,
        Css,
        CppObjDump,
        Cucumber,
        Cython,
        D,
        DObjDump,
        DarcsPatch,
        Dart,
        Dcpu16Asm,
        Dot,
        Dylan,
        Ec,
        EcereProjects,
        Ecl,
        Edn,
        Eiffel,
        Elixir,
        Elm,
        EmacsLisp,
        Erlang,
        FSharp,
        Factor,
        Fancy,
        Fantom,
        Fish,
        Forth,
        Fortran,
        Gas,
        Genshi,
        GentooBuild,
        GentooEclass,
        GettextCatalog,
        Glsl,
        Go,
        Gosu,
        Groff,
        Groovy,
        GroovyServerPages,
        Haml,
        HandleBars,
        Haskell,
        Haxe,
        Http,
        Ini,
        Io,
        Ioke,
        IrcLog,
        J,
        Java,
        JavaServerPages,
        JavaScript,
        Json,
        Julia,
        JupyterNotebook,
        Kotlin,
        Lasso,
        Less,
        Lfe,
        LillyPond,
        LiterateCoffeeScript,
        LiterateHaskell,
        LiveScript,
        Llvm,
        Logos,
        Logtalk,
        Lua,
        M,
        Makefile,
        Mako,
        Markdown,
        Matlab,
        Max,
        MiniD,
        Mirah,
        Monkey,
        Moocode,
        Moonscript,
        Mupad,
        Myghty,
        Nemerle,
        Nginx,
        Nimrod,
        Nsis,
        Nu,
        NumPY,
        ObjDump,
        ObjectiveC,
        ObjectiveJ,
        OCaml,
        Omgrofl,
        Ooc,
        Opa,
        OpenCL,
        OpenEdgeAbl,
        Parrot,
        ParrotAssembly,
        ParrotInternalRepresentation,
        Pascal,
        Perl,
        Php,
        Pike,
        PogoScript,
        PowerShell,
        Processing,
        Prolog,
        Puppet,
        PureData,
        Python,
        PythonTraceback,
        R,
        Racket,
        RagelInRubyHost,
        RawTokenData,
        Rebol,
        Redcode,
        ReStructuredText,
        Rhtml,
        Rouge,
        Ruby,
        Rust,
        Scala,
        Scheme,
        Sage,
        Sass,
        Scilab,
        Scss,
        Self,
        Shell,
        Slash,
        Smalltalk,
        Smarty,
        Squirrel,
        StandardML,
        SuperCollider,
        Tcl,
        Tcsh,
        Tea,
        TeX,
        Textile,
        Toml,
        Turing,
        Twig,
        Txl,
        TypeScript,
        UnifiedParallelC,
        Unknown,
        Vala,
        Verilog,
        Vhdl,
        VimL,
        VisualBasic,
        Volt,
        Wisp,
        Xc,
        Xml,
        XProc,
        XQuery,
        Xs,
        Xslt,
        Xtend,
        Yaml,
    }
}
