ifeq ($(V),1)
	Q =
else
	Q = @
endif

mcs ?= $(Q)mcs
echo = $(Q)echo
mkdir = $(Q)mkdir -p
rm = $(Q)rm -rf

objdir = bin
srcdir = src

src = $(wildcard $(srcdir)/*.cs)
obj = $(subst $(srcdir)/,$(objdir)/,$(patsubst %.cs,%.exe,$(src)))

refs = -pkg:dotnet -lib:/usr/lib/mono/2.0

all: $(obj)

$(objdir):
	$(mkdir) $@

$(obj): $(objdir)/%.exe: $(srcdir)/%.cs
	$(mcs) $(refs) -out:$@ $<

$(objdir)/Singleton2.exe: refs = -lib:/usr/lib/mono/4.0

clean:
	$(rm) $(obj)
