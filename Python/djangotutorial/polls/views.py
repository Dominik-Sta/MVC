from django.shortcuts import HttpResponse

def index(request):
    return HttpResponse("Coś tam. You're at polls index.")

# Create your views here.
