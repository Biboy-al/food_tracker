import 'package:frontend/Models/Food.dart';
import 'package:http/http.dart' as http;
import 'dart:convert';

import './i_food_service.dart';


class FoodService extends IFoodService{

  final String url = "http//:127.0.0.1:5432";

  @override
  Future<List<dynamic>> fetchAllFood() async {
    
    final response =  await http.get(Uri.parse(url));
    List<dynamic> body = jsonDecode(response.body);

    return body;
  }

  @override
  Future<Food> saveFood() {
    // TODO: implement saveFood
    throw UnimplementedError();
  }


}