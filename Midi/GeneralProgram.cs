using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleMidiPlayer.Midi
{
    public enum GeneralProgram
    {
        PIANO_钢琴 = 1,
        CHROMATIC_PERCUSSION_半音打击乐器 = 2,
        ORGAN_风琴 = 3,
        GUITAR_吉他 = 4,
        BASS_贝司 = 5,
        SOLO_STRINGS_弦乐独奏 = 6,
        ENSEMBLE_合唱或合奏 = 7,
        BRASS_铜管乐器 = 8,
        PIPE_吹管乐器 = 9,
        SYNTH_LEAD_合成主音 = 10,
        SYNTH_PAD_合成柔音 = 11,
        SYNTH_EFFECTS_合成特效 = 12,
        ETHNIC_民族乐器 = 13,
        PERCUSSIVE_打击乐 = 14,
        SOUND_EFFECTS_声音特效 = 15
    }

    public enum GeneralProgramEN
    {
        PIANO = 1,
        CHROMATIC_PERCUSSION = 2,
        ORGAN = 3,
        GUITAR = 4,
        BASS = 5,
        SOLO_STRINGS = 6,
        ENSEMBLE = 7,
        BRASS = 8,
        PIPE = 9,
        SYNTH_LEAD = 10,
        SYNTH_PAD = 11,
        SYNTH_EFFECTS = 12,
        ETHNIC = 13,
        PERCUSSIVE = 14,
        SOUND_EFFECTS = 15
    }

    /// <summary>
    /// 钢琴
    /// </summary>
    public enum PIANO
    {
        Acoustic_Grand_Piano_大钢琴 = 1,
        Bright_Acoustic_Piano_亮音大钢琴 = 2,
        Electric_Grand_Piano_电钢琴 = 3,
        Honky_Tonk_Piano_酒吧钢琴 = 4,
        Rhodes_Piano_练习音钢琴 = 5,
        Chorused_Piano_合唱加钢琴 = 6,
        Harpsichord_拨弦古钢琴 = 7,
        Clavinet_击弦古钢琴 = 8
    }
    /// <summary>
    /// 半音打击乐器
    /// </summary>
    public enum CHROMATIC_PERCUSSION
    {
        Celesta_钢片琴 = 9,
        Glockenspiel_钟琴 = 10,
        Music_Box_八音盒 = 11,
        Vibraphone_电颤琴 = 12,
        Marimba_马林巴 = 13,
        Xylophone_木琴 = 14,
        Tubular_Bells_管钟 = 15,
        Dulcimer_扬琴 = 16
    }

    /// <summary>
    /// 风琴
    /// </summary>
    public enum ORGAN
    {
        Hammond_Organ_击杆风琴 = 17,
        Percussive_Organ_打击型风琴 = 18,
        Rock_Organ_摇滚风琴 = 19,
        Church_Organ_管风琴 = 20,
        Reed_Organ_簧风琴 = 21,
        Accordion_手风琴 = 22,
        Harmonica_口琴 = 23,
        Tango_Accordian_探戈手风琴 = 24
    }
    /// <summary>
    /// 吉他
    /// </summary>
    public enum GUITAR
    {
        Acoustic_Guitar_nylon_尼龙弦吉他 = 25,
        Acoustic_Guitar_steel_钢弦吉他 = 26,
        Electric_Guitar_jazz_爵士乐电吉他 = 27,
        Electric_Guitar_clean_清音电吉他 = 28,
        Electric_Guitar_muted_弱音电吉他 = 29,
        Overdriven_Guitar_驱动音效吉他 = 30,
        Distortion_Guitar_失真音效吉他 = 31,
        Guitar_Harmonics_吉他泛音 = 32
    }

    /// <summary>
    /// 贝司
    /// </summary>
    public enum BASS
    {
        Acoustic_Bass_原声贝司 = 33,
        Electric_Bass_finger_指拨电贝司 = 34,
        Electric_Bass_pick_拨片拨电贝司 = 35,
        Fretless_Bass_无品贝司 = 36,
        Slap_Bass_1_击弦贝司1 = 37,
        Slap_Bass_2_击弦贝司2 = 38,
        Synth_Bass_1_合成贝司1 = 39,
        Synth_Bass_2_合成贝司2 = 40
    }
    /// <summary>
    /// 弦乐独奏
    /// </summary>
    public enum SOLO_STRINGS
    {
        Violin_小提琴 = 41,
        Viola_中提琴 = 42,
        Cello_大提琴 = 43,
        Contrabass_低音提琴 = 44,
        Tremolo_Strings_弦乐震音 = 45,
        Pizzicato_Strings_弦乐拨奏 = 46,
        Orchestral_Harp_竖琴 = 47,
        Timpani_定音鼓 = 48
    }
    /// <summary>
    /// 合唱或合奏
    /// </summary>
    public enum ENSEMBLE
    {
        String_Ensemble_1_弦乐合奏1 = 49,
        String_Ensemble_2_弦乐合奏2 = 50,
        SynthStrings_1_合成弦乐1 = 51,
        SynthStrings_2_合成弦乐2 = 52,
        Choir_Aahs_合唱_啊_音 = 53,
        Voice_Oohs_人声_嘟_音 = 54,
        Synth_Voice_合荿人声 = 55,
        Orchestra_Hit_乐队打击乐 = 56
    }
    /// <summary>
    /// 铜管乐器
    /// </summary>
    public enum BRASS
    {
        Trumpet_小号 = 57,
        Trombone_长号 = 58,
        Tuba_大号 = 59,
        Muted_Trumpet_弱音小号 = 60,
        French_Horn_圆号 = 61,
        Brass_Section_铜管组 = 62,
        Synth_Brass_1_合成铜管1 = 63,
        Synth_Brass_2_合成铜管2 = 64
    }
    /// <summary>
    /// 吹管乐器
    /// </summary>
    public enum PIPE
    {
        Piccolo_短笛 = 73,
        Flute_长笛 = 74,
        Recorder_竖笛 = 75,
        Pan_Flute_排笛 = 76,
        Bottle_Blow_吹瓶口 = 77,
        Skakuhachi_尺八 = 78,
        Whistle_哨 = 79,
        Ocarina_洋埙 = 80
    }
    /// <summary>
    /// 合成主音
    /// </summary>
    public enum SYNTH_LEAD
    {
        Lead_1_square_合成主音1_方波 = 81,
        Lead_2_sawtooth_合成主音2_锯齿波 = 82,
        Lead_3_calliope_lead_合成主音3_汽笛风琴 = 83,
        Lead_4_chiff_lead_合成主音4_吹管 = 84,
        Lead_5_charang_合成主音5_吉他 = 85,
        Lead_6_voice_合成主音6_人声 = 86,
        Lead_7_fifths_合成主音7_五度 = 87,
        Lead_8_bass_lead_合成主音8_低音加主音 = 88
    }
    /// <summary>
    /// 合成柔音
    /// </summary>
    public enum SYNTH_PAD
    {
        Pad_1_new_age_合成柔音1_新时代 = 89,
        Pad_2_warm_合成柔音_暖音 = 90,
        Pad_3_polysynth_合成柔音3_复合成 = 91,
        Pad_4_choir_合成柔音4_合唱 = 92,
        Pad_5_bowed_合成柔音5_弓弦 = 93,
        Pad_6_metallic_合成柔音6_金属 = 94,
        Pad_7_halo_合成柔音7_光环 = 95,
        Pad_8_sweep_合成柔音8_扫弦 = 96
    }
    /// <summary>
    /// 合成特效
    /// </summary>
    public enum SYNTH_EFFECTS
    {
        FX_1_rain_合成特效1_雨 = 97,
        FX_2_soundtrack_合成特效2_音轨 = 98,
        FX_3_crystal_合成特效3_水晶 = 99,
        FX_4_atmosphere_合成特效4_大气 = 100,
        FX_5_brightness_合成特效5_亮音 = 101,
        FX_6_goblins_合成特效6_小妖 = 102,
        FX_7_echoes_合成特效7_回声 = 103,
        FX_8_sci_fi_合成特效8_科幻 = 104
    }
    /// <summary>
    /// 民族乐器
    /// </summary>
    public enum ETHNIC
    {
        Sitar_锡塔尔 = 105,
        Banjo_班卓 = 106,
        Shamisen_三味线 = 107,
        Koto_筝 = 108,
        Kalimba_卡林巴 = 109,
        Bagpipe_风笛 = 110,
        Fiddle_古提琴 = 111,
        Shanai_唢呐 = 112
    }
    /// <summary>
    /// 打击乐
    /// </summary>
    public enum PERCUSSIVE
    {
        Tinkle_Bell_铃铛 = 113,
        Agogo_拉丁打铃 = 114,
        Steel_Drums_钢鼓 = 115,
        Woodblock_木块 = 116,
        Taiko_Drum_太鼓 = 117,
        Melodic_Tom_嗵鼓 = 118,
        Synth_Drum_合成鼓 = 119,
        Reverse_Cymbal_镲波形反转 = 120
    }
    /// <summary>
    /// 声音特效
    /// </summary>
    public enum SOUND_EFFECTS
    {
        Guitar_Fret_Noise_磨弦声 = 121,
        Breath_Noise_呼吸声 = 122,
        Seashore_海浪声 = 123,
        Bird_Tweet_鸟鸣声 = 124,
        Telephone_Ring_电话铃声 = 125,
        Helicopter_直升机声 = 126,
        Applause_鼓掌声 = 127,
        Gunshot_枪声 = 128
    }















}

