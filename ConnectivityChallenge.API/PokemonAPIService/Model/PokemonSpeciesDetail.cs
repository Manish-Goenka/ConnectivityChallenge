using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ConnectivityChallenge.API.PokemonAPIService.Model
{
    public  class PokemonSpeciesDetail
    {
        [JsonPropertyName("base_happiness")]
        public long BaseHappiness { get; set; }

        [JsonPropertyName("capture_rate")]
        public long CaptureRate { get; set; }

        [JsonPropertyName("color")]
        public Color Color { get; set; }

        [JsonPropertyName("egg_groups")]
        public List<Color> EggGroups { get; set; }

        [JsonPropertyName("evolution_chain")]
        public EvolutionChain EvolutionChain { get; set; }

        [JsonPropertyName("evolves_from_species")]
        public Color EvolvesFromSpecies { get; set; }

        [JsonPropertyName("flavor_text_entries")]
        public List<FlavorTextEntry> FlavorTextEntries { get; set; }

        [JsonPropertyName("form_descriptions")]
        public List<object> FormDescriptions { get; set; }

        [JsonPropertyName("forms_switchable")]
        public bool FormsSwitchable { get; set; }

        [JsonPropertyName("gender_rate")]
        public long GenderRate { get; set; }

        [JsonPropertyName("genera")]
        public List<Genus> Genera { get; set; }

        [JsonPropertyName("generation")]
        public Color Generation { get; set; }

        [JsonPropertyName("growth_rate")]
        public Color GrowthRate { get; set; }

        [JsonPropertyName("habitat")]
        public Color Habitat { get; set; }

        [JsonPropertyName("has_gender_differences")]
        public bool HasGenderDifferences { get; set; }

        [JsonPropertyName("hatch_counter")]
        public long HatchCounter { get; set; }

        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("is_baby")]
        public bool IsBaby { get; set; }

        [JsonPropertyName("is_legendary")]
        public bool IsLegendary { get; set; }

        [JsonPropertyName("is_mythical")]
        public bool IsMythical { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("names")]
        public List<Name> Names { get; set; }

        [JsonPropertyName("order")]
        public long Order { get; set; }

        [JsonPropertyName("pal_park_encounters")]
        public List<PalParkEncounter> PalParkEncounters { get; set; }

        [JsonPropertyName("pokedex_numbers")]
        public List<PokedexNumber> PokedexNumbers { get; set; }

        [JsonPropertyName("shape")]
        public Color Shape { get; set; }

        [JsonPropertyName("varieties")]
        public List<Variety> Varieties { get; set; }
    }

    public  class Color
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }
    }

    public  class EvolutionChain
    {
        [JsonPropertyName("url")]
        public Uri Url { get; set; }
    }

    public  class FlavorTextEntry
    {
        [JsonPropertyName("flavor_text")]
        public string FlavorText { get; set; }

        [JsonPropertyName("language")]
        public Color Language { get; set; }

        [JsonPropertyName("version")]
        public Color Version { get; set; }
    }

    public  class Genus
    {
        [JsonPropertyName("genus")]
        public string GenusGenus { get; set; }

        [JsonPropertyName("language")]
        public Color Language { get; set; }
    }

    public  class Name
    {
        [JsonPropertyName("language")]
        public Color Language { get; set; }

        [JsonPropertyName("name")]
        public string NameName { get; set; }
    }

    public  class PalParkEncounter
    {
        [JsonPropertyName("area")]
        public Color Area { get; set; }

        [JsonPropertyName("base_score")]
        public long BaseScore { get; set; }

        [JsonPropertyName("rate")]
        public long Rate { get; set; }
    }

    public  class PokedexNumber
    {
        [JsonPropertyName("entry_number")]
        public long EntryNumber { get; set; }

        [JsonPropertyName("pokedex")]
        public Color Pokedex { get; set; }
    }

    public  class Variety
    {
        [JsonPropertyName("is_default")]
        public bool IsDefault { get; set; }

        [JsonPropertyName("pokemon")]
        public Color Pokemon { get; set; }
    }
}
